create database foo
GO

use foo
GO

create table cars ( id int, make varchar(60), model varchar(60), color varchar(60) )
GO

insert into cars values (1, 'ford', 'mustang', 'red'),  (2, 'ford', 'f150', 'blue'),  (3, 'chevy', 'camaro', 'black'),  (4, 'chevy', 'corvette', 'yellow')
GO

select * from cars
GO
