Use ComputerGames;
GO
Create Procedure SearchRatingsGame
@game varchar(70)
AS
BEGIN
Select Games.name_, AVG(Reviews.rating) as 'Средний рейтинг пользователей' FROM Games, Reviews
Where Games.id = Reviews.game
Group by Games.name_
END