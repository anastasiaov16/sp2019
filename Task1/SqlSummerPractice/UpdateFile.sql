go 
create procedure UpdateFile
@oldName varchar(50),
@name varchar(50),
@id int
as

update [FSSS].[dbo].[File]
set Title = @name
where Id = 
(select IdFile from [FSSS].[dbo].[UserFile] 
where IdUser = @id
and IdFile = (select Id from [FSSS].[dbo].[File] where Title = @oldName ))

exec UpdateFile 'KursovayaNikita', 'KursovayaNikita1',6

select * from [FSSS].[dbo].[File]

drop procedure UpdateFile