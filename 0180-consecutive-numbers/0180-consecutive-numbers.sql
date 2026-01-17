/* Write your T-SQL query statement below */
WITH CTE AS 
(
    SELECT 
        LAG(num, 1) OVER(ORDER BY id) AS pre_num, 
        num, 
        LEAD(num, 1) OVER(ORDER BY id) AS next_num
    FROM Logs
)
SELECT DISTINCT num AS ConsecutiveNums 
FROM CTE 
WHERE pre_num = num AND next_num = num