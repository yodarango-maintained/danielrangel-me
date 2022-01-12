

CREATE TABLE UserAdmin(
ID INT NOT NULL AUTO_INCREMENT,
About_Me VARCHAR(2000),
YouVersion_Url CHAR(255),
Github_Url CHAR(255),
Instagram_Url CHAR(255),
Reddit_Url CHAR(255),
Goodreads_url CHAR(255),
Youtube_url CHAR(255),
Twitter_url CHAR(255),
LinkedIn_url CHAR(255),
Strava_url CHAR(255),
PRIMARY KEY(ID)
);

INSERT INTO UserAdmin(
About_Me,
YouVersion_Url,
Github_Url,
Instagram_Url,
Reddit_Url,
Goodreads_url,
Youtube_url,
Twitter_url,
LinkedIn_url,
Strava_url
)
VALUES(
"Hey I am Daniel",
"http://www.bible.com",
"http://www.github.com",
"http://www.insagram.com",
"http://www.reddit.com",
"http://www.goodreads.com",
"http://www.youtube.com",
"http://www.twitter.com",
"http://www.linkedin.com",
"http://www.strava.com"
);