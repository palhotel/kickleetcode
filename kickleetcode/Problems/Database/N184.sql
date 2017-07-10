select Department.Name as Department, Employee.`Name` as Employee, employee.Salary
from department
join employee ON 
employee.DepartmentId = department.Id 
and 
employee.Salary in (select max(t.salary) from employee t where t.DepartmentId = department.Id )
