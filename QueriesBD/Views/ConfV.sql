Use ComputerGames;
GO
Create View ConfV
AS
Select Configurations_.id as ID, Games.name_ as ����, Configurations_.CP as ���������, Configurations_.RAM as ���, Engines.name_ as ������ 
FROM Configurations_, Games, Engines
WHERE Configurations_.game = Games.id AND Configurations_.engine = Engines.id;