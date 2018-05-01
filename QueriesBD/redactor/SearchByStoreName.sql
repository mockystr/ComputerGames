Use ComputerGames;
Go
Create Procedure SearchByStoreName
@name varchar(50)
AS
select * from StoresV where Название  like '%' + @name + '%'