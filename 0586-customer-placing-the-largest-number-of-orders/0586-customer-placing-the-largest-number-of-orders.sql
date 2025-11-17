/* Write your T-SQL query statement below */
SELECT customer_number
FROM
(
    SELECT TOP 1 customer_number, COUNT(*) AS order_total
    FROM Orders
    GROUP BY customer_number
    ORDER BY order_total DESC
)
AS T