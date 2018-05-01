Use ComputerGames;


GO
Create Procedure AddEditDeleteGames
@mode varchar(30),
@id int,
@name_ varchar(70),
@size int,
@limit int,
@genre int,
@publisher int,
@store int,
@price int,
@release_d date
AS
BEGIN
	if @mode='Add'
	BEGIN
	Insert Into Games(id,name_,size,limitation,genre,publisher,store, price,release_date)
	Values (@id, @name_, @size, @limit, @genre,@publisher,@store,@price,@release_d)
	END

	else if @mode = 'Edit'
	BEGIN
	Update Games
	Set id = @id, name_ = @name_, size = @size, limitation = @limit, genre = @genre, publisher = @publisher, store = @store, price = @price, release_date = @release_d
	Where id = @id
	END

	else if @mode = 'Delete'
	BEGIN
	DElete from Games
	Where id  = @id
	END
END
