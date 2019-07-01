create procedure FindFile
@name varchar(50),
@id int
as
select  
F.Title, 
F.DateOfCreation, 
F.Size
from [dbo].[File] as F
inner join [dbo].[UserFile] as UF on (UF.IdUser = @id and UF.IdFile = F.Id and F.Title = @name)

exec FindFile 'BdOtchet', 6