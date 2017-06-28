CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
      DECLARE M INT Default 0; 
      set M = N - 1;
  RETURN (

      # Write your MySQL query statement below.
       select DISTINCT Salary as SecondHighestSalary from Employee ORDER BY Salary DESC limit 1 OFFSET M
  );
END
