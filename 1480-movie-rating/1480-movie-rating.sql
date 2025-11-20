/* Write your T-SQL query statement below */
SELECT * FROM
(
    (
        SELECT TOP 1 U.name AS results
        FROM Users U
        JOIN MovieRating MR
        ON U.user_id = MR.user_id
        GROUP BY U.user_id, U.name
        ORDER BY COUNT(*) DESC, U.name
    )
    UNION ALL
    (
        SELECT TOP 1 M.title AS results
        FROM Movies M 
        JOIN MovieRating MR
        ON M.movie_id = MR.movie_id
        WHERE MR.created_at >= '2020-02-01' AND MR.created_at < '2020-03-01'
        GROUP BY M.movie_id, M.title
        ORDER BY AVG(MR.rating * 1.0) DESC, M.title
    )
)
AS T