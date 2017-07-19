 select stadium.id, stadium.date, stadium.people from stadium,
 (

			select s1.id as id1, s2.id as id2

			from stadium s1, stadium s2
			where s2.id  - s1.id >= 2
			and s1.people >= 100 
			and (
				select max(s5.people) 
				from stadium s5 
				where s5.id = s1.id - 1 or s5.id = s2.id + 1
			) < 100
			and (
				select min(s3.people) 
				from stadium s3 
				where s3.id >= s1.id 
				and s3.id <= s2.id
			) >=100

 ) s4
 where id >=s4.id1 and id <= s4.id2
