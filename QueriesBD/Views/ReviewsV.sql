Use ComputerGames;
GO
Create View ReviewsV
AS
Select Reviews.id as ID, Games.name_ as ��������, Reviews.review as �����, Reviews.rating as �������, Reviews.user_ as ������������
FROM Reviews, Games
Where Reviews.game = Games.id