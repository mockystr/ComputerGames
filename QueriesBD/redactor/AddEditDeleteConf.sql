Use ComputerGames;

GO
Create Procedure AddEditDeleteConf
@mode varchar(30),
@id int,
@game int,
@CP varchar(30),
@RAM varchar(30),
@VGA varchar(30),
@engine int
AS
BEGIN
	If @mode = 'Add'
	BEGIN
	Insert into dbo.Configurations_(id, game, CP, RAM, VGA, engine) VALUES (@id,@game, @CP, @RAM, @VGA, @engine);
	END
	ELSE IF @mode = 'Edit'
	BEGIN
	Update dbo.Configurations_ SET id= @id, game = @game, CP = @CP, RAM = @RAM, engine = @engine;
	END
	ELSE IF @mode = 'Delete'
	BEGIN
	Delete from dbo.Configurations_ WHERE id=@id;
	END
END