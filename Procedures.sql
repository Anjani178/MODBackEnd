create table employee (
id int primary key,
name varchar(20),
)

insert into employee values(1000,'Anjani');
insert into employee values(1001,'Nagraj');
insert into employee values(1002,'Sarkar');

select * from employee;

update employee set name = 'Meenakshi' where id = 1001;

delete employee where id=1002

create procedure ReadEmp
as
begin
	select* from employee
end

exec ReadEmp

create procedure insertEmp (@id int,@name varchar(20)) as
begin
	insert into employee values (@id,@name)
end

exec insertEmp 101,'Anjani'

create procedure updateEmp (@id int,@name varchar(20)) as
begin
	update employee set name=@name where id =@id
end

exec updateEmp 101,'anisur'

create procedure deleteEmp (@name varchar(20)) as
begin
	delete employee where name = @name 
end

exec deleteEmp 'anisur'