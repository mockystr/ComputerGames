Use ComputerGames;

Go
Create Procedure SearchReviewsByUsername
@username varchar(30)
AS
SELECT * From Reviews Where user_  Like '%' + @username + '%'
Go