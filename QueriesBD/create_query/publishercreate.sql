Use ComputerGames;

Create table Publisher(
id int Primary Key,
name varchar(50),
localizer int,
date_foundation date,
country varchar(50)
Foreign Key (localizer) References Localizers(id));