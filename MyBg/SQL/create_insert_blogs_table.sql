CREATE TABLE Blogs(
ID INT NOT NULL AUTO_INCREMENT,
Title CHAR(225),
Description VARCHAR(500),
Tumbnails VARCHAR(1000),
Categories VARCHAR(1000),
DatePosted DATETIME DEFAULT CURRENT_TIMESTAMP,
HTML TEXT,
PostType CHAR(255),
PRIMARY KEY(ID)
);

INSERT INTO Blogs(
Title,
Description,
Tumbnails,
Categories,
HTML,
PostType
)
VALUES(
"My First Post",
"This is the description of my very first post which i hope it does not endu up being way too long",
"",
"Tech sofware Eng Theology",
"<h1>Hello world</h1>",
"Blog"
);

show fields from Blogs;