Use ComputerGames;

GO
Create Procedure AddEditDeleteDev
@mode varchar(30),
@id int,
@name varchar(30),
@date_f date,
@country varchar(30),
@leader varchar(30)
AS
BEGIN
	IF @mode = 'Add'
	BEGIN
	Insert Into Developers(id,name_, date_foundation, country, leader)
	Values (@id,@name, @date_f,@country, @leader);
	END
	Else if @mode = 'Edit'
	BEGIN
	Update Developers SET id = @id, name_ = @name, date_foundation = @date_f, country = @country, leader = @leader
	WHERE id = @id;
	END
	Else if @mode = 'Delete'
	BEGIN 
	Delete FRom Developers WHERE id=  @id
	End
END