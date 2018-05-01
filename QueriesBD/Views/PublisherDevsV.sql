Use ComputerGames;

GO
CREate view PublisherDevsV
AS
SELect PublisherDevs.id as ID, Developers.name_ as Разработчик, Publishers.name_ as Издатель, descr as Описание FROM  PublisherDevs, Developers, Publishers
WHERE PublisherDevs.dev_id = Developers.id AND PublisherDevs.pub_id = Publishers.id