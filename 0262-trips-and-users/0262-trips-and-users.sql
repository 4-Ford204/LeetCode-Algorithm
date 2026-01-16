/* Write your T-SQL query statement below */
SELECT
    request_at AS Day,
    ROUND(
        SUM(
            CASE
                WHEN T.status IN ('cancelled_by_driver', 'cancelled_by_client')
                THEN 1 ELSE 0
            END
        ) * 1.0 / COUNT(*),
        2
    ) AS 'Cancellation Rate'
FROM Trips AS T
JOIN Users AS C ON T.client_id = C.users_id
JOIN Users AS D ON T.driver_id = D.users_id
WHERE
    C.banned = 'No' AND
    D.banned = 'No' AND
    T.request_at BETWEEN '2013-10-01' AND '2013-10-03'
GROUP BY request_at