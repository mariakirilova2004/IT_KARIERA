CREATE SCHEMA one_to_many;

CREATE TABLE manufacturers
(
	manufacturer_id	INT PRIMARY KEY,
    name VARCHAR(30),
    established_on DATE
);

CREATE TABLE models
(
	models_id	INT PRIMARY KEY,
    name VARCHAR(30),
    manufacturer_id INT,
    C
);