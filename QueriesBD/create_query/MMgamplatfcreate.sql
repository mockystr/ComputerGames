Use ComputerGames;

Create table GamePlatform(
id int Primary Key,
game int,
platform_ int,
Foreign Key (game) References Games(id),
Foreign Key (platform_) References Platforms(id));