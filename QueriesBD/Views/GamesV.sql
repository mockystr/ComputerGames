Use ComputerGames;
GO
Create View GamesV
AS
Select Games.id, Games.name_ as ��������, Games.size as ������, AgeLimits.type_ as ���������������, Genres.genre as ����, Publishers.name_ as ��������, Stores.name_ as �������, Games.price as ����, Games.release_date as �����������
FROM Games,AgeLimits,Genres,Publishers,Stores
Where AgeLimits.id = Games.limitation AND Genres.id = Games.genre AND Publishers.id = Games.publisher AND Stores.id =  Games.store;