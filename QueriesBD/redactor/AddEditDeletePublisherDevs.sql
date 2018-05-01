USE ComputerGames;
GO
Create Procedure AddEditDeletePublisherDevs
@mode varchar(30),
@id int,
@dev int,
@pub int,
@des varchar(150)
AS
Begin
	IF @mode = 'Add'
	Begin
	Insert Into PublisherDevs(id,dev_id,pub_id, descr) Values (@id, @dev, @pub, @des);
	End

	Else If @mode = 'Edit'
	Begin
	Update PublisherDevs
	Set id = @id, dev_id = @dev,pub_id = @pub , descr= @des
	Where id = @id;
	End

	Else If @mode = 'Delete'
	Begin
	Delete From PublisherDevs
	Where id = @id;
	End
End
