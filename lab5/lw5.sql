--2 Добавил таблицы
CREATE TABLE dvd (
	dvd_id	INTEGER NOT NULL UNIQUE,
	title	TEXT NOT NULL,
	production_year	INTEGER NOT NULL,
	PRIMARY KEY(dvd_id AUTOINCREMENT)
);

CREATE TABLE customer (
	customer_id	INTEGER NOT NULL UNIQUE,
	first_name	TEXT NOT NULL,
	last_name	TEXT NOT NULL,
	passport_code	INTEGER NOT NULL,
	registration_date	TEXT NOT NULL,
	PRIMARY KEY(customer_id AUTOINCREMENT)
);

CREATE TABLE offer (
	offer_id	INTEGER NOT NULL UNIQUE,
	dvd_id	INTEGER NOT NULL,
	customer_id	INTEGER NOT NULL,
	offer_date	TEXT NOT NULL,
	return_date	TEXT,
	PRIMARY KEY(offer_id AUTOINCREMENT)
);

--3 подготовил SQL запросы для заполнения таблиц данными.

INSERT INTO dvd (title, production_year) VALUES ('Мстители: Финал', 2019);
INSERT INTO dvd (title, production_year) VALUES ('Аватар', 2009);
INSERT INTO dvd (title, production_year) VALUES ('Звездные войны: Пробуждение силы', 2015);
INSERT INTO dvd (title, production_year) VALUES ('Мститетли: Война бесконечности', 2018);
INSERT INTO dvd (title, production_year) VALUES ('Титаник', 1997);
INSERT INTO dvd (title, production_year) VALUES ('Мир Юрского приода', 2015);
INSERT INTO dvd (title, production_year) VALUES ('Король Лев', 2019);
INSERT INTO dvd (title, production_year) VALUES ('Мстители', 2012);
INSERT INTO dvd (title, production_year) VALUES ('Форсаж 7', 2015);
INSERT INTO dvd (title, production_year) VALUES ('Холоднео сердце 2', 2019);
INSERT INTO dvd (title, production_year) VALUES ('Черная пантера', 2018);
INSERT INTO dvd (title, production_year) VALUES ('Начало', 2010);
INSERT INTO dvd (title, production_year) VALUES ('Как приручить дракона', 2010);
INSERT INTO dvd (title, production_year) VALUES ('Гадкий я', 2010);

INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Краснов', 'Игорь', 8085111111, date('2002-05-10'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Павел', 'Павлов', 9715115693, date('2018-06-03'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Антон', 'Скворцов', 9401324567, date('2003-05-05'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Анастасия', 'Алексеева', 9499123456, date('2010-01-12'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ева', 'Волкова', 9813987654, date('2009-07-07'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Александра', 'Иванова', 9312100000, date('2011-09-10'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Артем', 'Николаев', 9510453627, date('2013-02-02'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Полина', 'Бутылина', 9310456789, date('2010-01-01'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Егор', 'Петров', 9510123456, date('2006-06-06'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Светлана', 'Тихонова', 9689123456, date('2009-10-10'));

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (1, 1, date('2019-02-10'), date('2019-02-22'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (2, 2, date('2020-03-02'), date('2020-03-10'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (3, 3, date('2020-02-10'), date('2020-02-11'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (4, 4, date('2020-03-12'), date('2020-03-14'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (5, 5, date('2020-03-14'), date('2020-03-30'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (6, 6, date('2020-03-14'), date('2020-03-21'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (7, 7, date('2019-02-22'), date('2019-03-01'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (8, 8, date('2020-04-10'), null);
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (9, 9, date('2018-01-23'), date('2018-03-01'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (10,10, date('2020-04-01'), date('2020-04-15'));
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (12, 2, date('2020-04-02'), null);
INSERT INTO offer (dvd_id, customer_id, offer_date, return_date) VALUES (13, 4, date('2020-04-03'), date('2020-04-05'));

--4. Подготовьте SQL запрос получения списка всех DVD, год выпуска которых 2010, #10 отсортированных в алфавитном порядке по названию DVD.

SELECT * FROM dvd
WHERE dvd.production_year = 2010
ORDER BY title;

--5 Подготовьте SQL запрос для получения списка DVD дисков, которые в настоящее время #10 находятся у клиентов

SELECT dvd.dvd_id, dvd.title, dvd.production_year FROM dvd
INNER JOIN offer ON offer.dvd_id = dvd.dvd_id
WHERE 
	offer.return_date IS NULL;

--6 Напишите SQL запрос для получения списка клиентов, которые брали какие-либо DVD 
--#10 диски в текущем году. В результатах запроса необходимо также отразить какие диски 
--брали клиенты.

SELECT customer.customer_id, customer.first_name, customer.last_name, 
customer.passport_code, customer.registration_date, dvd.dvd_id, dvd.title
FROM customer 
INNER JOIN offer ON offer.customer_id = customer.customer_id
INNER JOIN dvd ON dvd.dvd_id = offer.dvd_id
WHERE 	
	strftime('%Y', DATE('NOW')) = strftime('%Y', offer.offer_date);

