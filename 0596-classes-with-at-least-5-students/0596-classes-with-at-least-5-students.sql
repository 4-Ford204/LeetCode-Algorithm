/* Write your T-SQL query statement below */
SELECT class
FROM
(
    SELECT class, COUNT(*) AS students
    FROM Courses
    GROUP BY class
    HAVING COUNT(*) >= 5
)
AS T