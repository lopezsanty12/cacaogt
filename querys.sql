-- Insert Category
insert into category (`name`, `description`) values ('Hogar','Asegura tu hogar');
insert into category (`name`, `description`) values ('Vigilancia','Equipos para vigilar tu hogar o lo que quieras');
insert into category (`name`, `description`) values ('Drones','Visualiza tu entorno diferente con drones y mejora su seguridad');

-- Truncate tables
SET FOREIGN_KEY_CHECKS = 0;
select now();
truncate category;
truncate products;

SET FOREIGN_KEY_CHECKS = 1;

-- Consult of tables
select * from category;
select * from products;
select * from cities;
select * from clients;

-- Insert Products of category 1
insert into products (`description`,`price`,`category`,`countProduct`) values ('Microfono espia',250.50,1,30);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Lentes incoporado con video y audio',3000,1,20);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Alarmas para tu casa',5500.50,1,17);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Seguros automaticas para ventanas',1500.58,1,5);

-- Insert Products of category 2
insert into products (`description`,`price`,`category`,`countProduct`) values ('DVR HKVision',7800.58,2,15);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Camara HKVision 720p',250,2,25);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Camara HKVision 1080p',500.58,2,15);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Camara con sensor 720p',1500,2,15);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Camara vision nocturna',8500,2,10);

-- Inser prorducts category 3
insert into products (`description`,`price`,`category`,`countProduct`) values ('DJI Camera Drones',8000,3,5);
insert into products (`description`,`price`,`category`,`countProduct`) values ('GoPro Camera Drones',9500,3,10);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Parrot Camera Drones',10000,3,3);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Yuneec Camera Drones',12500,3,8);
insert into products (`description`,`price`,`category`,`countProduct`) values ('Forcel U49W',13500,3,3);

-- Insert cities
insert into cities (`name`,`size`,`rate`,`average`) values ('Quetzaltenango',150000,23.3,3500);
insert into cities (`name`,`size`,`rate`,`average`) values ('Retalhuleu',100000,15.5,3000);
insert into cities (`name`,`size`,`rate`,`average`) values ('San Marcos',98570,16.7,2800);
insert into cities (`name`,`size`,`rate`,`average`) values ('Totonicapan',85000,35.3,4000);
insert into cities (`name`,`size`,`rate`,`average`) values ('Jutiapa',102000,19.3,3300);
insert into cities (`name`,`size`,`rate`,`average`) values ('Peten',75000,11.3,2500);

-- Insert clients
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (85628697,'Santiago','Lopez','1a calle 2-12, Zona 3, Esperanza',40196841,'1995-09-12',1,6);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (89456512,'Randy','Camacho','3a calle 1-20, Zona 1',89564578,'1990-02-15',1,1);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (45658978,'Pedro','Ramirez','6a calle 9-22, Zona 10',85456235,'1993-03-21',1,5);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (56124568,'Rosa','Sanchez','4a calle 2-2',12345678,'1997-10-12',1,14);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (45689789,'Leslie','Diaz','4a calle 2-2, Zona 1, San Mateo',12345678,'1990-03-20',1,13);

insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (35654566,'Margarito','Perez','Calle 2-2, Zona 4',12345678,'1990-11-01',2,10);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (45687942,'Juan','Velasquez','6a calle 4-23',12345678,'1991-12-31',2,7);

insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (56879423,'Alejandra','Riquiac','4a calle 20-21, Zona 4',12345678,'1990-11-01',3,1);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (89745640,'Pedro','Pelico','8a calle 15-21, Zona 1',12345678,'1996-12-20',3,4);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (89546123,'Marcos','Tzun','10a calle 1-21, Zona 3',12345678,'1991-08-15',3,9);

insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (89745642,'Armando','Baldeti','19a calle 1-21, Zona 1',12345678,'1990-03-25',4,8);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (56489756,'Isabel','Ralac','9a Zona 8',12345678,'1988-03-28',4,11);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (89735640,'Jessica','Monterroso','Colonia Villa Nueva',12345678,'1989-04-12',4,6);

insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (23056435,'Vilda','Reyes','9a calle 10-2, zona 10',12345678,'1989-07-12',5,8);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (23056435,'Jerson','Ramirez','4a calle 11-0, zona 2',12345678,'1985-02-19',5,2);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (78946565,'Pedro','Escalante','6a calle 12-5, zona 4',12345678,'1989-05-23',5,5);

insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (45647564,'Rocio','Gomez','8a calle 11-55, zona 1',12345678,'1990-04-13',6,4);
insert into clients (`NIT`,`firstName`,`lastName`,`address`,`phone`,`dateBirth`,`cities`,`products`) values (45647564,'Santos','Chuc','1a calle 1-5, zona 3',12345678,'1999-06-11',6,4);


select name,
count(name) as count
from cities as a
inner join clients as b
on a.idCities = b.cities
group by name;


select concat_ws(' ', firstName, lastName) as name,
address,
phone
from clients as a
inner join cities as b
on a.cities = b.idCities
where a.cities = '2';

select name,
description,
count(products) as count
from clients as a
inner join cities as b
on a.cities = b.idCities
inner join products as c
on a.products = c.idproduct
group by name, description
order by b.name asc;

select 
	a.name,
	d.description,
	count(c.producto) as cantidad 
from cities a
inner join clients b on a.idCities = b.cities
inner join asignationProduct c on b.idclients = c.cliente
inner join products d on d.idproduct = c.producto
where 
	a.name = 'Quetzaltenango'
group by d.description;



insert into asignationProduct (`cliente`,`producto`) select idclients, products from clients;

select * from asignationProduct;




