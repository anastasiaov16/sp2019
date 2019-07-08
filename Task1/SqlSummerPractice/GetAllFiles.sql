go
create procedure GetAllFiles
@id int
as
select  
F.Title, 
F.DateOfCreation, 
F.Size
from [dbo].[File] as F
inner join [dbo].[UserFile] as UF on (UF.IdUser = @id and UF.IdFile = F.Id)


exec GetAllFiles 1
drop procedure GetAllFiles