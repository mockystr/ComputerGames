Use ComputerGames;
GO
Create Procedure SearchByLocalizerCompany
@company varchar(50)
AS
Select * FRom LocalizersV Where Название = @company