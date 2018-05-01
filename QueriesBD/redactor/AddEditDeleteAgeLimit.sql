Use ComputerGames;

GO
Create Procedure AddEditDeleteAgeLimit
@mode varchar(30),
@id int,
@type varchar(30),
@des varchar(150)
AS
Begin
	IF @mode = 'Add'
	Begin
	Insert Into AgeLimits(id,type_,description_) Values (@id, @type, @des);
	End

	Else If @mode = 'Edit'
	Begin
	Update AgeLimits
	Set id = @id, type_ = @type, description_ = @des
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From AgeLimits
	Where id = @id;
	End
End
