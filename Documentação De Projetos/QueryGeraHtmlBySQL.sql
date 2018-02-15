begin

	declare @html varchar(2000) = '-' ;
	declare @index int = 0, @total int ,@aux int = 1, @colun int = 1 , @total_colun int ;
	declare @tabelas table(id_t int, id_c int, t_name varchar(200) , c_name varchar(200) , c_type varchar(200));
	declare @t_name varchar(200) , @c_name varchar(200) , @c_type varchar(200);
	declare @tabelasByName table(id int , t_name varchar(200));
	declare @build table(id int, row_t varchar(2000))

	insert into @tabelas(id_c, t_name,c_name,c_type)
	select 
		ROW_NUMBER() OVER(partition by T.name ORDER BY T.name),
		SUBSTRING(T.name,1,1) + LOWER(SUBSTRING(T.name,2,LEN(T.name))),
		SUBSTRING(C.name,1,1) + LOWER(SUBSTRING(C.name,2,LEN(C.name))),
		case TP.name
			when 'varchar' then ': string'
			when 'char' then ': string'
			when 'bigint' then ': number'
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

	WHILE @index <= @total
	begin	
	
		select @t_name = t_name from @tabelas where id_t = @index;

		set @html = @html + '<form [formGroup]="form' + @t_name + '" (ngSubmit)="validate' + @t_name + '()" >';
		set @html = @html + '  <div><h4>{{mensagem}}</h4></div>';

		set @total_colun = (select count(c_name) from @tabelas where id_t = @index)

		WHILE @colun <= @total_colun
		begin
			select @c_name = c_name, @c_type = c_type from @tabelas where id_t = @index and id_c = @colun ;
			set @html = @html + '  <div>';
			set @html = @html + '    <div><label for="'+ @c_name +'">'+ @c_name +'</label></div>';
			set @html = @html + '    <div><input type="text" name="'+ @c_name +'" id="'+ @c_name +'" [(ngModel)]="' + @t_name + '.'+ @c_name +'" formControlName="'+ @c_name +'" ></div>';
			set @html = @html + '  </div>';
			set @colun = @colun + 1;
		end

		set @html = @html + '  <div>';
		set @html = @html + '    <div><button type="submit">Add</button></div>';
		set @html = @html + '    <div><button>Cancelar</button></div>';
		set @html = @html + '  </div>';
		set @html = @html + '</form>';

		insert into @build(id,row_t)
		values(@index, @html);
		set @html = ' '

		set @index = @index + 1;
		set @colun = 1;

	end

	select * from @build;

end

