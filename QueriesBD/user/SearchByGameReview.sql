Use ComputerGames;
GO
Create Procedure SearchByGameReview
@game int
AS
SElect Games.id, Games.name_ as ����, Reviews.review As �����, Reviews.rating as �������,
Reviews.user_ as ������������
FROM Games, Reviews
Where Games.id = Reviews.game and Reviews.game = @game