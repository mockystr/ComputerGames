use ComputerGames;

GO
Create Procedure EditReview
@id int,
@game int,
@review text,
@rating int,
@user_ varchar(30)
AS
BEGIN
UPDATE Reviews
Set @game = game, review = @review, rating = @rating, user_= @user_
Where id = @id
END