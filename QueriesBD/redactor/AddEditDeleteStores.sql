USE ComputerGames
GO
Create Procedure AddEditDeleteStores
@mode varchar(30),
@id int,
@name varchar(50),
@e_a varchar(50),
@des varchar(150)
AS
Begin
	IF @mode = 'Add'
	Begin
	Insert Into Stores(id,name_,e_address,description_) Values (@id, @name, @e_a, @des);
	End

	Else If @mode = 'Edit'
	Begin
	Update Stores
	Set id = @id, name_ = @name, e_address =@e_a, description_ = @des
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From Stores
	Where id = @id;
	End
End
