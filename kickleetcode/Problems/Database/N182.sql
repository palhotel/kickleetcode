select DISTINCT p1.email as Email from person p1, person p2
where p1.Id <> p2.Id and p1.Email = p2.Email
