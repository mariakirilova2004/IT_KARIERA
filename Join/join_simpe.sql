SELECT employee_id, job_title, a.address_id, a.address_text
FROM employees AS e
JOIN addresses AS a ON 
e.address_id = a.address_id
ORDER BY address_id LIMIT 5;

SELECT employee_id, first_name, last_name, d.name AS department_name
FROM employees AS e
JOIN departments AS d 
ON e.department_id = d.department_id
WHERE d.name = 'Sales'
ORDER BY employee_id DESC;

SELECT employee_id, first_name, salary, d.name AS department_name
FROM employees e
JOIN departments AS d
ON e.department_id = d.department_id
WHERE e.salary >= 15000
ORDER BY e.department_id 
LIMIT 5;

SELECT e.employee_id, e.first_name FROM employees AS e
WHERE e.employee_id NOT IN   (
							SELECT DISTINCT ep.employee_id FROM employees_projects AS ep
							)
ORDER BY e.employee_id desc
LIMIT 3;

SELECT e.employee_id, e.first_name, m.employee_id as 'manager_id', m.first_name as 'manager_name'
FROM employees AS e
INNER JOIN employees AS m ON m.employee_id = e.manager_id
WHERE e.manager_id IN (3,7)
ORDER BY e.first_name;

SELECT e.salary, d.name
FROM employees e
WHERE e.salary IN 
(
	SELECT salary 
    FROM employees
    WHERE
    (
		
    )
)
