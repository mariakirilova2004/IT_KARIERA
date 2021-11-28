CREATE SCHEMA car_rental;
CREATE TABLE categories
(
	id INT PRIMARY KEY,
    category VARCHAR(30),
    daily_rate DOUBLE(5,2),
    weekly_rate DOUBLE(5, 2),
    monthly_rate DOUBLE(5, 2),
    weeken_rate DOUBLE(5, 2)
);

CREATE TABLE cars
(
	id INT PRIMARY KEY,
    plate_number INT(4),
    make VARCHAR(26),
    model VARCHAR(30),
    car_year DATE,
    category_id INT,
    CONSTRAINT fk_cars_categories
    FOREIGN KEY (category_id)
    REFERENCES categories (id),
    doors INT,
    CONSTRAINT CHK_cars CHECK (doors <= 6),
    picture BLOB,
    car_condition TEXT,
    available BOOLEAN
);

CREATE TABLE employees
(
	id INT PRIMARY KEY,
    first_name VARCHAR(30),
    last_name VARCHAR(30),
    title VARCHAR(30),
    notes TEXT
);

CREATE TABLE customers
(
	id INT PRIMARY KEY,
	driver_licence_number INT,
    full_name VARCHAR(30),
    address VARCHAR(26),
    city VARCHAR(30),
    zip_code INT(4),
    notes TEXT
);

CREATE TABLE rental_orders
(
	id INT PRIMARY KEY,
    employee_id INT,
    CONSTRAINT fk_rental_orders_employees
    FOREIGN KEY (employee_id)
    REFERENCES employees(id),
    customer_id INT,
    CONSTRAINT fk_rental_orders_customers
    FOREIGN KEY (customer_id)
    REFERENCES customers(id),
    car_id INT,
    CONSTRAINT fk_rental_orders_cars
    FOREIGN KEY (car_id)
    REFERENCES cars(id),
    car_condition TEXT,
    tank_level DOUBLE(5, 2),
    kilometrage_start DOUBLE (20,2),
    kilometrage_end DOUBLE(20,2),
    total_kilometrage DOUBLE(20,2),
    start_date DATE,
    end_date DATE,
    total_days INT,
    rate_applied DOUBLE(4, 2),
    tax_rate INT,
    order_status BOOLEAN,
    notes TEXT
);


