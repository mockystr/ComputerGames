Use ComputerGames;

GO
Create Procedure AddEditDeleteEngines
@mode varchar(30),
@id int,
@name varchar(50),
@date_ date
AS
BEGIN
	If @mode = 'Add'
	Begin
	Insert into Engines(id,name_,date_) Values (@id,@name,@date_)
	End

	Else If @mode = 'Edit'
	BEgin
	Update Engines
	Set id= @id, name_ = @name, date_ = @date_
	Where id = @id;
	End

	Else if @mode = 'Delete'
	Begin
	Delete From Engines
	Where id = @id
	End
End