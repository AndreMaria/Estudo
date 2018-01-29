CREATE TABLE IF NOT EXISTS `Users` (
	`id` bigint(20) NOT NULL,
	`name` varchar(300) COLLATE utf8_unicode_ci NOT NULL,
	`email` varchar(300) COLLATE utf8_unicode_ci NOT NULL,
	`passworld` varchar(300) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=0 ;

ALTER TABLE `Users` ADD PRIMARY KEY (`id`);
 
ALTER TABLE `Users`
MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=0;


DELIMITER //
    CREATE PROCEDURE GetUser(IN filter VARCHAR(300))
        LANGUAGE SQL
        DETERMINISTIC
        SQL SECURITY DEFINER
        BEGIN
            SELECT * FROM Users 
			WHERE 
				UPPER(email) LIKE CONCAT('%',UPPER('AND') , '%' )
				OR UPPER(name) LIKE  CONCAT('%',UPPER('AND') , '%' )
        END //
		
		
		
		
DELIMITER;


DELIMITER //
    CREATE PROCEDURE GetLogin(IN email VARCHAR(300),IN passworld VARCHAR(300))
        LANGUAGE SQL
        DETERMINISTIC
        SQL SECURITY DEFINER
        BEGIN
            SELECT * FROM Users WHERE email = email AND passworld = passworld;
        END //


Expression of type Option[util.List[_]] doesn´t conform to expected type Option[List[User]]