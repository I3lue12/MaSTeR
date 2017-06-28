--week2 assignment chpter4

-- show databases;
--Question 1

-- select book_code, title from book;

-- Quetsion 2

-- select * from BRANCH;

--Question 3

--select publisher_name from publisher where (city = 'Boston');

--Question 4

--select publisher_name, city from publisher where (city <> 'New York');

--Question 5

-- select branch_name from branch where ( num_employees >= 9 );

--Question 6
-- select book_code, title from book where (type = 'HOR');

--Question 7
-- select book_code, title, type, paperback from book where (type = 'HOR') and (paperback = 'Y');

--Question 8
-- select book_code, title, type, 

--Question 9
-- select book_code, title, price from book where(price >= 15 and <= 25);

--Question 10
-- select book_code, title, type, price from book where (type = 'MYS') and (price < 20);

--Question 11
-- alter table book add DISCOUNTED_PRICE decimal (4,2);
-- select book_code, title, (price * 0.9) as DISCOUNTED_PRICE from book; 

--Question 12
-- select publisher_name from publisher where (publisher_name like '% and %');

-- Question 13
-- select book_code, title, type from book where (type = 'SFI') or (type = 'MYS') or (type = 'HOR');
-- select book_code, title, type from book where type IN ('HOR', 'SFI', 'MYS');

--Question 14
-- select book_code, type, title from book where type IN ('HOR', 'SFI', 'MYS') order by title;

--Question 15
-- select book_code, type, title, price from book where type IN ('HOR', 'SFI', 'MYS') order by price desc, title;

--Question 16
--select type from book group by type;

--Question 17
-- select type from book count(*, 'SFI');
-- select count(*) from book where type in(select type from book group by type);
-- select count(*) from book where type = 'SFI';
--Question 18
-- select type, truncate((avg(price), 2) as Average_Price from book group by type;
--Question 19
-- select type, truncate(avg(price), 2) as Average_Price from book where (paperback ='Y') group by type;
--Question 20
-- select type, avg(price) as Average_Price from book where (paperback ='Y')  group by type having (avg(price) > 10) ;
--Question 21

-- select price, title from book where (price = 5.99);
-- select price, title from book where price = (select min(price)from book);
-- select price, title from book where price = (select max(price)from book);

-- Question 22
-- select sum(num_employees) from branch;