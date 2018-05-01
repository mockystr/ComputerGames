Use ComputerGames;
GO
Create Procedure AddEditDeleteGamesPlatforms
@mode varchar(30),
@id int,
@game int,
@platform int,
@des varchar(150)
AS
BEGIN
	If @mode = 'Add'
	Begin
	Insert into GamePlatform(id,game,platform_,descr) Values (@id,@game,@platform, @des)
	End

	Else If @mode = 'Edit'
	BEgin
	Update GamePlatform
	Set id= @id, game = @game, platform_= @platform
	Where id = @id;
	End

	Else if @mode = 'Delete'
	Begin
	Delete From GamePlatform
	Where id = @id
	End
End