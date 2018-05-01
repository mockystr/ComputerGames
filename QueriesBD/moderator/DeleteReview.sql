Use ComputerGames;

GO
Create Procedure DeleteReview
@id int
As
DELETE FROM Reviews
WHERE id = @id
GO