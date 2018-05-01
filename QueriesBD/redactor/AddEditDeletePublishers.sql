USE ComputerGames;
GO
Create Procedure AddEditDeletePublishers
@mode varchar(30),
@id int,
@name int,
@localizer int,
@date date,
@country varchar(50)
AS
Begin
	IF @mode = 'Add'
	Begin
	Insert Into Publishers(id,name_,localizer, date_foundation, country) Values (@id, @name, @localizer, @date, @country);
	End

	Else If @mode = 'Edit'
	Begin
	Update Publishers
	Set id = @id, name_ = @name, localizer = @localizer, date_foundation = @date, country = @country
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From Publishers
	Where id = @id;
	End
End
