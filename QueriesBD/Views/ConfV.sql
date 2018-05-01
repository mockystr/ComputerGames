Use ComputerGames;
GO
Create View ConfV
AS
Select Configurations_.id as ID, Games.name_ as Игра, Configurations_.CP as Процессор, Configurations_.RAM as ОЗУ, Engines.name_ as Движок 
FROM Configurations_, Games, Engines
WHERE Configurations_.game = Games.id AND Configurations_.engine = Engines.id;