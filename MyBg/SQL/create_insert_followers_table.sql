CREATE TABLE Followers(
ID INT NOT NULL AUTO_INCREMENT,
Follower_Name CHAR(225),
Email CHAR(200),
Date_Subscribed DATETIME DEFAULT CURRENT_TIMESTAMP,
Not_A_Bot BOOL NOT NULL,
Avatar CHAR(255) NOT NULL,
PRIMARY KEY(ID)
);

INSERT INTO Followers(
Follower_Name,
Email,
Not_A_Bot,
Avatar
)
VALUES(
"John Doe",
"JohnDoe@example.com",
true,
"images/profile/avatar"
);

show fields from Followers;