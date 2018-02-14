begin

	declare @html varchar(2000) = '-' ;
	declare @index int = 0, @total int ;
	declare @tabelas table(id_t int, id_c int, t_name varchar(200) , c_name varchar(200) , c_type varchar(200));
	declare @t_name varchar(200) , @c_name varchar(200) , @c_type varchar(200);
	declare @tabelasByName table(id int , t_name varchar(200));
	declare @build table(id int, row_t varchar(2000))

	insert into @tabelas(id_c, t_name,c_name,c_type)
	select 
	ROW_NUMBER() OVER(partition by T.name ORDER BY T.name),
	T.name, 
	C.name, 
	case TP.name
		when 'varchar' then ' string'
		when 'char' then ' string'
		when 'bigint' then ' number'
		else ': any'
	end
	from sys.tables T inner join sys.columns C on T.object_id = c.object_id
	inner join sys.types TP on C.system_type_id = TP.system_type_id
	order by T.name;

	insert into @tabelasByName(t_name)
	select distinct t_name from @tabelas;

	update @tabelasByName
	set @index = id = @index + 1;

	set @index = 1;

	set @total =  (select count(*) from (select distinct t_name from @tabelas) as T);

	WHILE  @index <= @total
	begin
		select @t_name = t_name from @tabelasByName where id = @index;
		
		update @tabelas
		set id_t = @index
		where t_name = @t_name;

		set @index = @index + 1;
	end

	select * from @tabelas;

	set @index = 1;

	set @html = @html + '  const appRoutes: Routes = [';

	WHILE @index <= @total
	begin	
		select @t_name = t_name from @tabelas where id_t = @index;
		set @html = @html + ' { path: ''' + @t_name + '''' + ', component: ' + @t_name + 'Component },';
		set @index = @index + 1;
	end
	set @html = @html + '  ];';

	insert into @build(id,row_t)
	values(1, @html);

	select * from @build;

end

