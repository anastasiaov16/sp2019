go
create procedure GetTitleForDelete
@id int,
@title varchar(50)
as
if(exists(select IdFile from [FSSS].[dbo].[UserFile] 
where IdUser = @id
and IdFile = (select Id from [FSSS].[dbo].[File] where Title = @title)))
	select 1
else
	select 0

exec GetTitleForDelete 3,'table1'

drop procedure GetTitleForDelete

go
create procedure GetNameForCreate
@id int,
@name varchar(50)
as
if(exists(select Id from [dbo].[login] where Id = @id and NameOfUser = @name))
	select 1
else
	select 0

exec GetNameForCreate 1,'Anton'

drop procedure GetNameForCreate

go
create procedure GetPasswordForCreate
@id int,
@pas varchar(50)
as
if(exists(select Id from [dbo].[login] where Id = @id and Password = @pas))
	select 1
else
	select 0

exec GetPasswordForCreate 1,'anton'

drop procedure GetPasswordForCreate

go
create procedure GetPasswordForRegistrate
@pas varchar(50)
as
if(exists(select Id from [dbo].[login] where Password = @pas))
	select 1
else
	select 0

exec GetPasswordForRegistrate 'anton'

drop procedure GetPasswordForRegistrate

go
create procedure GetLoginForSend
@log varchar(50)
as
if(exists(select Id from [dbo].[login] where Login = @log))
	select 1
else
	select 0

exec GetLoginForSend 'Anton'

drop procedure GetLoginForSend
