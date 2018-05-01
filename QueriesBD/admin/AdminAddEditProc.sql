Use ComputerGames;

GO
Create Procedure AdminAddOrEdit
@mode varchar(10),
@id int,
@username varchar(30),
@pass varchar(30),
@role_ varchar(30)
AS
	IF @mode='Add'
	Begin
	Insert into LoginTable(id,username,pass,role_)
	Values (@id,@username,@pass,@role_)
	END
GO