create procedure DeleteFile
@title varchar(50),
@date date,
@id int
as
delete from [dbo].[UserFile]
where IdFile = (select Id from [dbo].[File] where Title = @title and DateOfCreation = @date) and IdUser = @id

delete from [dbo].[File]
where Title = @title and DateOfCreation = @date


select * from [dbo].[UserFile]

exec DeleteFile 'kursovaya', '1970-01-01', 2