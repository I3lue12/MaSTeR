-- select book.book_code, Author.author_num from book, Author;
-- can write it as
-- select b.book_code, A.author_num from book B, Author A,

-- select b.book_code, A.author_num from bookB, Author A, 
-- wrote w where(B.book-code= w.book-code) and (w.author_num=A.author_num);

--writeing in sql now
select B.book_code, A.author_num, title, author_first, author_last from
book B, author A, wrote W where (B.book_code=W.book_code) and (W.author_num=A.author_num);