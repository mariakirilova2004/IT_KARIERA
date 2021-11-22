CREATE TABLE directors
(
	id INT PRIMARY KEY,
    director_name VARCHAR(30),
    notes TEXT    
);

CREATE TABLE genres 
(
	id INT PRIMARY KEY,
    genre_name VARCHAR(30),
    notes TEXT    
);

CREATE TABLE categories 
(
	id INT PRIMARY KEY,
    categorie_name VARCHAR(30),
    notes TEXT    
);

CREATE TABLE movies 
(
	id INT PRIMARY KEY,
    title VARCHAR(30),
    director_id INT,
    CONSTRAINT fk_movies_directors
    FOREIGN KEY (director_id)
    REFERENCEs directors(id),
    copyright_year DATE,
    length TIME,
    genre_id INT,
    CONSTRAINT fk_movies_genres
    FOREIGN KEY(genre_id)
    REFERENCES genres(id),
    category_id INT,
    CONSTRAINT fk_movies_categories
    FOREIGN KEY(category_id)
    REFERENCES categories (id),
    rating INT,
    notes TEXT    
);

