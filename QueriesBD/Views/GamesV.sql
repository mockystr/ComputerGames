Use ComputerGames;
GO
Create View GamesV
AS
Select Games.id, Games.name_ as Название, Games.size as Размер, AgeLimits.type_ as ВозрОграничение, Genres.genre as Жанр, Publishers.name_ as Издатель, Stores.name_ as Магазин, Games.price as Цена, Games.release_date as ДатаВыпуска
FROM Games,AgeLimits,Genres,Publishers,Stores
Where AgeLimits.id = Games.limitation AND Genres.id = Games.genre AND Publishers.id = Games.publisher AND Stores.id =  Games.store;