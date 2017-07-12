delete From person
where person.id in (
select fuck.id from(
select p1.id  from person p1
where p1.email in 
(select email from person p2
 where p2.email = p1.email and p1.id > p2.id)
) fuck
)
-- better solution
-- DELETE p1
-- FROM Person p1, Person p2
-- WHERE p1.Email = p2.Email AND
-- p1.Id > p2.Id
