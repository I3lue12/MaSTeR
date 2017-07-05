-- select book.book_code, Author.author_num from book, Author;
-- can write it as
-- select b.book_code, A.author_num from book B, Author A,

-- select b.book_code, A.author_num from bookB, Author A, 
-- wrote w where(B.book-code= w.book-code) and (w.author_num=A.author_num);

--writeing in sql now
-- select B.book_code, A.author_num, title, author_first, author_last from
-- book B, author A, wrote W where (B.book_code=W.book_code) and (W.author_num=A.author_num);

--start chapter 5 pg 168
--Question 1
-- select b.book_code, b.title, p.publisher_code, p.publisher_name 
-- from book b, publisher p where (p.publisher_code = b.publisher_code)
-- order by publisher_name;

--Question 2
-- select b.book_code, b.title, b.price
-- from book b, publisher p where (p.publisher_code = b.publisher_code)
-- and (p.publisher_name = 'Scribner');

--Question 3
-- select b.title, b.book_code, p.publisher_name
-- from book b, publisher p where (p.publisher_code = b.publisher_code)
-- and (p.publisher_name = 'Scribner') and (price >= 14);

--Question 4
-- select b.book_code, b.title, i.on_hand
-- from book b, inventory i where (b.book_code = i.book_code)
-- and (i.branch_num = 3);

--Question 5
-- select b.title, b.type, p.publisher_name
-- from book b, publisher p where (b.publisher_code = p.publisher_code)
--  and (b.type='PSY') and (p.publisher_name = 'Berkley Publishing');

--Question 6
-- select title
-- from book b, author a wrote w where (b.book_code = w.book_code)and
-- (w.author_num=a.author_num)and(a.author_num in (18));


-- select title from book where book_code in
-- (select book_code from wrote where(author_num = 18));

--Question 7
-- select title from book where exists
-- (select * from book_code from wrote where(author_num = 18));

--Question 8
-- select b.book_code, title from wrote w, book b, inventory i 
-- where
-- (b.book_code = w.book_code) and
-- (w.book_code = i.book_code) and
-- (b.book_code = i.book_code) and 
-- (i.branch_num = 2) and
-- (w.author_num=20);
--Question 9
-- select f.book_code, s.book_code from book f, book s where 
-- (f.price = s.price) and (f.book_code > s.book_code) order by f.book_code asc;

--Question 10
-- select title, author_last, on_hand from book b, author a, inventory i, wrote w where
--  (b.book_code=w.book_code)and
--  (a.author_num=w.author_num)and
--  (i.book_code=b.book_code) and
--  (i.book_code=w.book_code)and
--  (i.branch_num = 4);

--Question 11
-- select title, author_last, on_hand from book b, author a, inventory i, wrote w where
--  (b.book_code=w.book_code)and
--  (a.author_num=w.author_num)and
--  (i.book_code=b.book_code) and
--  (i.book_code=w.book_code)and
--  (i.branch_num = 4) and
--  (b.paperback = 'Y');

--Question 12
-- select book_code, title from book b, publisher p where
-- (b.publisher_code=p.publisher_code)and
-- ((p.city = 'Boston')or
-- (b.price > 10));

--Question 13
-- select book_code, title from book b, publisher p where
-- (b.publisher_code=p.publisher_code)and
-- (p.city = 'Boston') and
-- (b.price > 10);

--Question 14
-- select book_code, title from book b, publisher p where
-- (b.publisher_code=p.publisher_code)and
-- (b.price)and
-- (p.city != 'Boston');

--Question 15
-- select book_code, title from book where (price > (select max(price)from book where type = 'MYS'));

--Question 16
-- select book_code, title from book where (price > (select min(price)from book where type = 'MYS'));

--Question 17
-- select b.book_code, title, i.on_hand, i.branch_num from book b left join
-- inventory i on((b.book_code=i.book_code)and
-- (i.branch_num ='2')) order by b.book_code;