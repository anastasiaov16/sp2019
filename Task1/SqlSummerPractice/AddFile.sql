USE [FSSS]
GO
create procedure AddFile
@name varchar(50),
@date date,
@size int,
@id int
as
INSERT INTO [dbo].[File]
           ([Id]
           ,[Title]
           ,[DateOfCreation]
           ,[Size])
     VALUES((select MAX([Id]) from [dbo].[File])+1, @name, @date, @size)

INSERT INTO [dbo].[UserFile]
			([Id]
           ,[IdUser]
           ,[IdFile])
	values((select MAX([Id]) from [dbo].[UserFile])+1, @id, (select MAX([Id]) from [dbo].[File]))


exec AddFile 'kursovaya', '1970-01-01', 25, 2

select * from [dbo].[UserFile]

INSERT INTO [dbo].[File]
           ([Id]
           ,[Title]
           ,[DateOfCreation]
           ,[Size])
     VALUES(1, 'doklad', '2019-01-01', 13)

	 drop procedure AddFile