Use ComputerGames;

Create table PublisherDevs(
id int Primary Key,
dev_id int,
pub_id int,
Foreign Key (dev_id) References Developers(id),
Foreign Key (pub_id) References Publisher(id));