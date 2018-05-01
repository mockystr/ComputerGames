Use ComputerGames;

GO
Create Procedure SearchByGameConf
@game int
AS
SELECT * FROM Configurations_ WHERE game = @game;
