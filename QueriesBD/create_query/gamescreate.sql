Use ComputerGames;

Create table Games(
id int PRIMARY KEY,
name varchar(70),
size int,
limitation int,
genre int,
publisher int,
store int,
price int,
release_date date,
Foreign Key (genre) References Genres(id),
Foreign Key (publisher) References Publisher(id),
Foreign Key (store) References Store(id),
Foreign Key (limitation) References AgeLimit(id));