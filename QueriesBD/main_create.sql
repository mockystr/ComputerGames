Use ComputerGames;

Create table Localizers(
id int Primary Key,
name_ varchar(50) NOT NULL,
description_ varchar(150),
leader varchar(50));

Create table Developers(
id int Primary Key,
name_ Varchar(50) NOT NULL,
date_foundation date,
country Varchar(30),
leader varchar(30));

Create table Publisher(
id int Primary Key,
name_ varchar(50) NOT NULL,
localizer int,
date_foundation date,
country varchar(50),
Foreign Key (localizer) References Localizers(id) ON UPDATE CASCADE);

Create table PublisherDevs(
id int Primary Key,
dev_id int NOT NULL,
pub_id int NOT NULL,
descr varchar(150),
Foreign Key (dev_id) References Developers(id) ON DELETE CASCADE ON UPDATE CASCADE,
Foreign Key (pub_id) References Publisher(id) ON DELETE CASCADE ON UPDATE CASCADE);

Create table AgeLimit(
id int PRIMARY KEY,
type_ varchar(10) NOT NULL,
description_ varchar(150));

Create table Store(
id int Primary Key,
name_ varchar(50) NOT NULL,
e_address varchar(50),
description_ varchar(150));

Create table Engines(
id int Primary Key,
name_ varchar(50) NOT NULL,
date_ date);

Create table Platforms(
id int Primary Key,
name_ varchar(50) NOT NULL,
description_ varchar(150));

Create table Genres(
id int Primary Key,
genre varchar(30) NOT NULL,
description_ varchar(150));

Create table Games(
id int PRIMARY KEY,
name_ varchar(70) NOT NULL,
size int,
limitation int,
genre int,
publisher int,
store int,
price int,
release_date date,
Foreign Key (genre) References Genres(id) ON UPDATE CASCADE,
Foreign Key (publisher) References Publisher(id) ON UPDATE CASCADE,
Foreign Key (store) References Store(id) ON UPDATE CASCADE,
Foreign Key (limitation) References AgeLimit(id) ON UPDATE CASCADE);

Create table Reviews(
id int PRIMARY KEY IDENTITY(1,1),
game int NOT NULL,
review text NOT NULL,
rating int NOT NULL,
user_ varchar(30) NOT NULL,
Foreign Key (game) References Games(id) ON DELETE CASCADE ON UPDATE CASCADE);

Create table Configuration(
id int PRIMARY KEY,
game int NOT NULL,
CP varchar(30) NOT NULL,
RAM varchar(30) NOT NULL,
VGA varchar(30) NOT NULL,
engine int,
Foreign Key (game) References Games(id) ON DELETE CASCADE ON UPDATE CASCADE,
Foreign Key (engine) References Engines(id) ON UPDATE CASCADE);

Create table GamePlatform(
id int Primary Key,
game int NOT NULL,
platform_ int NOT NULL,
descr varchar(150),
Foreign Key (game) References Games(id) ON DELETE CASCADE ON UPDATE CASCADE,
Foreign Key (platform_) References Platforms(id) ON DELETE CASCADE ON UPDATE CASCADE);