CREATE TABLE Movies (
  MovieId INT PRIMARY KEY,
  Title VARCHAR(100) NOT NULL,
  ReleaseYear INT NOT NULL,
  Genre VARCHAR(50) NOT NULL,
  Director VARCHAR(100) NOT NULL,
  Rating DECIMAL(2,1) NOT NULL
);