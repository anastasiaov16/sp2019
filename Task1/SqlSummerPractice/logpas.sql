go 
create procedure LogPas
@login varchar(50),
@password varchar (50)
as
IF (EXISTS (SELECT Login, Password FROM Login WHERE @login = Login and @password = Password)) 
begin
	select Id from [dbo].[Login] 
	WHERE @login = Login and @password = Password
end
ELSE
    SELECT  0
GO

EXEC LogPas 'Anton', 'anton'


drop procedure LogPas

insert into Login(Id, NameOfUser, Login, Password) values (1, 'Anton', 'Anton', 'anton')