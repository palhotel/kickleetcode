select class from courses
group BY class 
HAVING count(DISTINCT student) >=5
