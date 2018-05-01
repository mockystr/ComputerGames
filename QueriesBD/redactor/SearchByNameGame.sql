Use ComputerGames;

GO
Create Procedure SearchByNameGame
@name varchar(70)
AS
SELECT * FROM Games Where name_ Like '%' + @name + '%';