CREATE TABLE Favorites(
ID INT NOT NULL AUTO_INCREMENT,
Title CHAR(225),
Description VARCHAR(500),
Tumbnails VARCHAR(1000),
Categories VARCHAR(1000),
DatePosted DATETIME DEFAULT CURRENT_TIMESTAMP,
Link VARCHAR(500),
HTML TEXT,
PostType CHAR(255),
PRIMARY KEY(ID)
);

INSERT INTO Favorites(
Title,
Description,
Tumbnails,
Categories,
Link,
HTML,
PostType
)
VALUES(
"My First Post",
"This is the description of my very first post which i hope it does not endu up being way too long",
"",
"Tech sofware Eng Theology",
"Jira.com",
"<h1>Hello world</h1>",
"Favorite"
);

show fields from Favorites;
