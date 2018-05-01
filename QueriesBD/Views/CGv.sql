Use ComputerGames;

GO
Create View CGv
AS
Select GamePlatform.id as ID, Games.name_ AS Игра, Platforms.name_ as Платформа, descr as Описание FROM GamePlatform, Games,Platforms
WHERE GamePlatform.game = Games.id AND GamePlatform.platform_ = Platforms.id;