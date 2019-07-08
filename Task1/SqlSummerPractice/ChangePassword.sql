go 
create procedure ChangePassword
@oldPas varchar(50),
@pas varchar(50),
@id int
as

update [FSSS].[dbo].[Login]
set Password = @pas
where Id = @id
and Password = @oldPas

exec ChangePassword 'anton1', 'anton',1

select * from [FSSS].[dbo].[Login]

drop procedure ChangePassword