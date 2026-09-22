/* Write your T-SQL query statement below */
SELECT name, SUM(T.amount) AS balance
FROM Users AS U
JOIN Transactions AS T
ON U.account = T.account
GROUP BY U.account, name
HAVING SUM(T.amount) > 10000