Use ComputerGames;
GO
Create View ReviewsV
AS
Select Reviews.id as ID, Games.name_ as Название, Reviews.review as Обзор, Reviews.rating as Рейтинг, Reviews.user_ as Пользователь
FROM Reviews, Games
Where Reviews.game = Games.id