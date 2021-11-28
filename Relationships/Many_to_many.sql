CREATE SCHEMA many_to_many;

CREATE TABLE students
(
	students_id INT PRIMARY KEY,
    name VARCHAR(26)
);

CREATE TABLE exams
(
	exam_id INT PRIMARY KEY,
    name VARCHAR(26)
);

CREATE TABLE students_exams
(
	student_id INT,
    CONSTRAINT  fk_students_exams_students
    FOREIGN KEY (student_id)
    REFERENCES students(students_id),
	exam_id INT,
	CONSTRAINT  fk_students_exams_exams
    FOREIGN KEY (exam_id)
    REFERENCES exams(exam_id)
    
);

ALTER TABLE students_exams
ADD PRIMARY KEY (student_id, exam_id);