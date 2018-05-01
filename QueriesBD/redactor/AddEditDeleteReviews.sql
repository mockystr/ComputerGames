USE ComputerGames
GO
Create Procedure AddEditDeleteReviews
@mode varchar(30),
@id int,
@game int,
@review text,
@rating int,
@user varchar(30)
AS
Begin
	IF @mode = 'Add'
	Begin
	Insert Into Reviews(id,game,review, rating, user_) Values (@id, @game, @review, @rating, @user);
	End

	Else If @mode = 'Edit'
	Begin
	Update Reviews
	Set game = @game, review = @review, rating = @rating, user_ = @user
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From Reviews
	Where id = @id;
	End
End
