Use ComputerGames;

GO
Create Procedure SearchByCompanyDev
@company varchar(30)
AS
BEGIN
Select * From Developers Where name_ LIKE '%' + @company + '%';
END