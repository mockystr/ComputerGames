Use ComputerGames;
GO
Create Procedure AddEditDeleteGenres
@mode varchar(30),
@id int,
@genre varchar(30),
@des varchar(150)
AS
BEGIN
	IF @mode = 'Add'
	Begin
	Insert Into Genres(id,genre,description_) Values (@id, @genre, @des);
	End

	Else If @mode = 'Edit'
	Begin
	Update Genres
	Set id = @id, genre =@genre , description_ = @des
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From Genres
	Where id = @id;
	End
END