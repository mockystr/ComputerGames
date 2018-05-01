Use ComputerGames;
Go
Create Procedure SearchByPubDev
@pub int
AS
Select * From PublisherDevsV Where Издатель = @pub;