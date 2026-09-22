/* Write your T-SQL query statement below */
SELECT name, balance
FROM Users AS U
JOIN 
(
    SELECT account, SUM(amount) AS balance
    FROM Transactions
    GROUP BY account
    HAVING SUM(amount) > 10000
)
AS T
ON U.account = T.account