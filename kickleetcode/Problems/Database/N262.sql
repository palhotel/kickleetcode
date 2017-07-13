select r1 as Day, ROUND((num2/num1),2) as 'Cancellation Rate' from 
(select t1.r1, IFNULL(t2.num2,0) as num2, t1.num1 from (SELECT count(`Status`) as num1,Request_at as r1 from trips,users 
where trips.Client_Id = users.users_id and users.Banned <> 'Yes' and trips.Request_at >= '2013-10-01' and trips.Request_at <= '2013-10-03'
GROUP BY Request_at) t1
left JOIN
(SELECT count(`Status`) as num2, Request_at as r2 from trips,users 
where trips.Client_Id = users.users_id and users.Banned <> 'Yes' and trips.`Status` <>'completed' and trips.Request_at >= '2013-10-01' and trips.Request_at <= '2013-10-03'
GROUP BY Request_at) t2
on t1.r1 = t2.r2
)
ttt
