SELECT name as customers from customers
WHERE Id not in (select customerid from orders)
