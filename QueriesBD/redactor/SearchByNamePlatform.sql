Use ComputerGames;
Go
Create Procedure SearchByNamePlatform
@name varchar(50)
AS
Select * From Platforms Where name_ like '%' + @name + '%';