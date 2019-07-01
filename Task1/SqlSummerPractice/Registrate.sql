go
create procedure Registrate
@name varchar(50),
@login varchar(50),
@password varchar (50)
as

insert into Login(Id, NameOfUser, Login, Password) values((select MAX(ID) from Login)+1, @name, @login, @password)


exec Registrate 'Petr', 'Pet321', 'lalala'

select * from [dbo].[UserFile]

drop procedure Registrate