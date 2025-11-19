/* Write your T-SQL query statement below */
SELECT DISTINCT
    P.id,
    CASE
        WHEN P.p_id IS NULL THEN 'Root'
        WHEN T.id IS NULL THEN 'Leaf'
        ELSE 'Inner'
    END AS type
FROM Tree AS P
LEFT JOIN TREE AS T
ON P.id = T.p_id;