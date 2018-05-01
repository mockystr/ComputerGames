Use ComputerGames;
GO
Create Procedure SearchByGenres
@genre varchar(30)
AS
Select * From Genres Where Genres.genre like '%' + @genre + '%';