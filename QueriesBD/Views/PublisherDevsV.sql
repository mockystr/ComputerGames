Use ComputerGames;

GO
CREate view PublisherDevsV
AS
SELect PublisherDevs.id as ID, Developers.name_ as �����������, Publishers.name_ as ��������, descr as �������� FROM  PublisherDevs, Developers, Publishers
WHERE PublisherDevs.dev_id = Developers.id AND PublisherDevs.pub_id = Publishers.id