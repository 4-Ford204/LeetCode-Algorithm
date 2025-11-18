/* Write your T-SQL query statement below */
SELECT
    STU.student_id,
    student_name,
    SUB.subject_name,
    COUNT(E.subject_name) AS attended_exams
FROM Students AS STU
CROSS JOIN Subjects AS SUB
LEFT JOIN Examinations AS E
ON STU.student_id = E.student_id AND SUB.subject_name = E.subject_name
GROUP BY STU.student_id, student_name, SUB.subject_name
ORDER BY student_id, subject_name