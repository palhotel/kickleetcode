select max(Salary) as SecondHighestSalary from Employee 
 where Salary not in (select max(Salary) as SecondHighestSalary from Employee) 
