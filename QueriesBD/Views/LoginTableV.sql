Use ComputerGames;

GO
CREate view LoginTableV
AS
Select id as ID, username AS ИмяПользователя, pass as Пароль, role_ as Роль FROM LoginTable;