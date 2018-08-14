create database flights;
	use flights;

/*

*/

	create table details
		(
			flight_num int primary key,
			airline_code char(2) not null,
			departure_time datetime not null,
			arrival_time datetime not null,
			departure varchar(50),
			arrival varchar(50)
			);
		create table survey
			(
				review_num int primary key,
				flight_num int not null,
				friendliness int not null,
				space int not null,
				confort int not null,
				cleanliness int not null,
				noise int not null,
				review_optional Text
				);
			insert into details values(1628,'AA','2018-08-16 16:00:00','2018-08-16 20:20:00','Cincinnati','San Diego');
				insert into details values(2001,'LF','2018-08-16 16:00:00','2018-08-16 20:42:00','Stutgart','San Diego');
					insert into details values(2050,'BA','2018-08-16 16:00:00','2018-08-17 20:25:00','London','LA');
						insert into details values(3000,'DA','2018-08-16 16:00:00','2018-08-16 20:52:00','Cincinnati','San Diego');
