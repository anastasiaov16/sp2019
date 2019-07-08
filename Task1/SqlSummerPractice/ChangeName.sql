go 
create procedure ChangeName
@oldName varchar(50),
@name varchar(50),
@id int
as

update [FSSS].[dbo].[Login]
set NameOfUser = @name
where Id = @id
and NameOfUser = @oldName

exec ChangeName 'Anton1', 'Anton',1

select * from [FSSS].[dbo].[Login]

drop procedure ChangeName