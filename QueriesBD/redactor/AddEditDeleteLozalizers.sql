use ComputerGames;
GO
create procedure AddEditDeleteLozalizers
@mode varchar(30),
@id int,
@name varchar(50),
@des varchar(150),
@leader varchar(50)
AS
BEGIN
IF @mode = 'Add'
	Begin
	Insert Into Localizers(id,name_,description_, leader) Values (@id, @name, @des, @leader);
	End

	Else If @mode = 'Edit'
	Begin
	Update Localizers
	Set id = @id,  name_=@name, description_ = @des, leader = @leader
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From Localizers
	Where id = @id;
	End
END