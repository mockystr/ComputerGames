Use ComputerGames;
GO
Create Procedure SearchByGameReview
@game int
AS
SElect Games.id, Games.name_ as Игра, Reviews.review As Обзор, Reviews.rating as Рейтинг,
Reviews.user_ as Пользователь
FROM Games, Reviews
Where Games.id = Reviews.game and Reviews.game = @game