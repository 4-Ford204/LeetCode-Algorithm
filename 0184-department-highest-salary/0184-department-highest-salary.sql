/* Write your T-SQL query statement below */
SELECT D.name AS Department, E.name AS Employee, E.salary as Salary
FROM Department D
JOIN 
(
    SELECT
        name, departmentId, salary,
        DENSE_RANK() OVER (PARTITION BY departmentId ORDER BY salary DESC) AS rank
    FROM Employee
)
AS E
ON D.id = E.departmentId
WHERE E.rank = 1