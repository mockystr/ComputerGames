Use ComputerGames;

Create table Reviews(
id int PRIMARY KEY,
game int,
review text,
rating int,
user_ varchar(30),
Foreign Key (game) References Games(id));