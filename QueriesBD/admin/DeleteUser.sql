Use ComputerGames;

GO
Create Procedure DeleteUser
@id int
AS
DELETE from LoginTable
WHERE id = @id
GO