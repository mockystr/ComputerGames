Use ComputerGames;
GO
Create Procedure AddEditDeletePlatforms
@mode varchar(30),
@id int,
@name varchar(50),
@des varchar(150)
AS
BEGIN
	IF @mode = 'Add'
	Begin
	Insert Into Platforms(id,name_,description_) Values (@id, @name, @des);
	End

	Else If @mode = 'Edit'
	Begin
	Update Platforms
	Set id = @id, name_ = @name, description_ = @des
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From Platforms
	Where id = @id;
	End
END