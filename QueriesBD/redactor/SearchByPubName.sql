Use ComputerGames;
GO
Create Procedure SearchByPubName
@name varchar(50)
AS
Select * FRom PublishersV where Название like '%' + @name + '%';