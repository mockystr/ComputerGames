Use ComputerGames;
GO
Create Procedure SearchByGameRev
@game int
AS
Select * from ReviewsV Where Название = @game;