go
create procedure GetUser
@id int
as
select  
L.NameOfUser as '��� ������������', 
L.Login as '�����', 
L.Password as '������'
from [dbo].[Login] as L
where L.Id = @id


exec GetUser 1
drop procedure GetUser