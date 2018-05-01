Use ComputerGames;

Go
Create Procedure SearchUsersByRole
@role_ varchar(30)
As
SELECT * From LoginTable
Where role_ Like '%' + @role_+ '%'
Go