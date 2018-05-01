Use ComputerGames;

GO
Create View LocalizersV
AS
Select id AS ID, name_ as Название,description_ as Описание, leader as Лидер  FROM Localizers;