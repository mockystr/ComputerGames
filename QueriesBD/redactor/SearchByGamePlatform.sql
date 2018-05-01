Use ComputerGames;
GO
Create Procedure SearchByGamePlatform
@game int
AS
Select * FROM GamePlatform WHERE game = @game;