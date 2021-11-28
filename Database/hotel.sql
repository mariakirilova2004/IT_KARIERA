CREATE SCHEMA hotel;
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
	account_number INT PRIMARY KEY, 
    first_name VARCHAR(30), 
    last_name VARCHAR(30), 
    phone_number INT(10),
    emergency_name VARCHAR(30), 
    emergency_number INT(10), 
    notes TEXT
);
CREATE TABLE room_status 
(
	room_status VARCHAR(10),
    notes TEXT
);
CREATE TABLE room_types 
(
	room_types VARCHAR(10),
    notes TEXT
);
CREATE TABLE bed_types 
(
	bed_types VARCHAR(10),
    notes TEXT
);
CREATE TABLE rooms 
(
	room_number INT PRIMARY KEY, 
    room_type VARCHAR(10), 
    CONSTRAINT fk_rooms_roomtypes
    FOREIGN KEY (room_type)
    REFERENCES room_types(room_types),
    bed_type VARCHAR(10),
    CONSTRAINT fkB_rooms_bedtypes
    FOREIGN KEY (bed_type)
    REFERENCES bed_types(bed_types),
    rate DOUBLE(5, 2),
    room_status VARCHAR(10), 
    CONSTRAINT fkC_rooms_roomstatus
    FOREIGN KEY (room_status)
    REFERENCES room_status(room_status),
    notes TEXT
);
CREATE TABLE payments 
(
	id INT PRIMARY KEY, 
    employee_id INT,
    CONSTRAINT fk_payments_employee
    FOREIGN KEY (employee_id)
    REFERENCES employees(id),
    payment_date VARCHAR(30), 
    account_number INT,
	CONSTRAINT fk_payments_customers
    FOREIGN KEY (account_number)
    REFERENCES customers(id),
    first_date_occupied DATE, 
    last_date_occupied DATE, 
    total_days INT,
    amount_charged DOUBLE(6, 2), 
    tax_rate DOUBLE(6, 2),
    tax_amount DOUBLE(6, 2),
    payment_total DOUBLE(6, 2),
    notes TEXT
); 
 CREATE TABLE occupancies 
(
	id INT PRIMARY KEY, 
    employee_id INT,
    CONSTRAINT fk_occupancies_employee
    FOREIGN KEY (employee_id)
    REFERENCES employees(employee_id),
    date_occupied DATE, 
    CONSTRAINT fk_payments_occupancies
    FOREIGN KEY (date_occupied)
    REFERENCES payments(first_date_occupied),
    account_number INT,
    CONSTRAINT fk_occupancies_customers
    FOREIGN KEY (account_number)
    REFERENCES customers(id),
    room_number INT, 
    CONSTRAINT fk_rooms_occupancies
    FOREIGN KEY (room_number)
    REFERENCES rooms(room_number),
    rate_applied DOUBLE (5, 2), 
    phone_charge DOUBLE (5, 2),
    notes TEXT
); 
 
 
 
