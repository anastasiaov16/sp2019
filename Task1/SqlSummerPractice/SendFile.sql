go
create procedure SendFile
@name varchar(50),
@log varchar(50),
@id int
as

insert into UserFile(Id, IdFile, IdUser) values 
((select MAX([Id]) from [dbo].[File])+1, 
(select IdFile from [dbo].[UserFile] where IdUser = @id and IdFile = (select Id from [dbo].[File] where Title = @name)), 
(select Id from [dbo].[Login] where Login = @log))



exec SendFile 'table1', 'Pet321', 1

select * from UserFile

select * from [dbo].[File]

drop procedure SendFile

delete from UserFile
where Id > 2

