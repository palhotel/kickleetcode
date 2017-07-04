# Write your MySQL query statement below
select t1.Name as Employee
from employee t1, employee t2
where t1.ManagerId is not null and t1.ManagerId = t2.Id and t1.Salary > t2.Salary
