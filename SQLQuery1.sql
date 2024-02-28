create database simpleform
use simpleform

create table form (
   id int primary key identity,
   name varchar(50),
   email varchar(50),
   message varchar(100)
   );


   select * from form;
   insert into form (name,email,message) values('apple','hello@gmail.com','hello !!!')