CREATE SCHEMA soft_uni;

CREATE TABLE towns 
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30)
);
 
CREATE TABLE addresses 
(
	id INT PRIMARY KEY AUTO_INCREMENT, 
    address_text VARCHAR(40), 
    town_id INT,
    CONSTRAINT fk_addresses_towns
    FOREIGN KEY (town_id)
    REFERENCES towns(id)
);
 
CREATE TABLE departments  
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30)
);
 
CREATE TABLE employees 
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(30),
	middle_name VARCHAR(30),
    last_name VARCHAR(30), 
    job_title VARCHAR(30),
    department_id INT, 
    CONSTRAINT fk_employees_departments
    FOREIGN KEY (department_id)
    REFERENCES departments(id),
    hire_date DATE,
    salary DOUBLE(6, 2), 
    address_id INT,
	CONSTRAINT fk_employees_addresses
    FOREIGN KEY (address_id)
    REFERENCES addresses(id)
);

