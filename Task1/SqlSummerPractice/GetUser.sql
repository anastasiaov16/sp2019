go
create procedure GetUser
@id int
as
select  
L.NameOfUser as 'Имя пользователя', 
L.Login as 'Логин', 
L.Password as 'Пароль'
from [dbo].[Login] as L
where L.Id = @id


exec GetUser 1
drop procedure GetUser