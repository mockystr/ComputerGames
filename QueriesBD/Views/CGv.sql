Use ComputerGames;

GO
Create View CGv
AS
Select GamePlatform.id as ID, Games.name_ AS ����, Platforms.name_ as ���������, descr as �������� FROM GamePlatform, Games,Platforms
WHERE GamePlatform.game = Games.id AND GamePlatform.platform_ = Platforms.id;