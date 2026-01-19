/* Write your T-SQL query statement below */
WITH CTE AS
(
    SELECT *,
        COUNT(pid) OVER (PARTITION BY tiv_2015) AS tiv_2015_count,
        COUNT(pid) OVER (PARTITION BY lat, lon) AS location_count
    FROM Insurance
)
SELECT ROUND(SUM(tiv_2016), 2) AS tiv_2016
FROM CTE
WHERE tiv_2015_count > 1 AND location_count = 1