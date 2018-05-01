Use ComputerGames;

GO
Create Procedure SearchByNameEngine
@name varchar(50)
As
Begin
Select * From Engines
Where name_ Like '%' + @name + '%';
End