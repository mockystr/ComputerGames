Use ComputerGames;

Create table Configuration(
id int PRIMARY KEY,
game int,
CP varchar(30),
RAM varchar(30),
VGA varchar(30),
engine int,
Foreign Key (game) References Games(id),
Foreign Key (engine) References Engines(id));