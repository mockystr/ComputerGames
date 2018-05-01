Use ComputerGames;

GO
Create Procedure SearchByTypeAgeLimit
@type varchar(30)
AS
Begin
Select * From AgeLimits Where type_ LIKE '%' + @type +'%';
End