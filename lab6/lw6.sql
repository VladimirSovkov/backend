--1. (#15)  Напишите SQL запросы  для решения задач ниже. 

--Table "PC"
--    id  cpu(MHz)  memory(Mb)  hdd(Gb)
--    1      1600          2000             500
--    2      2400          3000             800
--    3      3200          3000             1200
--    4      2400          2000             500 




CREATE TABLE PC (
	id INTEGER NOT NULL UNIQUE,
	[cpu(MHz)]   INTEGER NOT NULL,
	[memory(Mb)] INTEGER NOT NULL,
	[hdd(Gb)]    INTEGER NOT NULL,
	PRIMARY KEY(id AUTOINCREMENT)
);

INSERT INTO PC ([cpu(MHz)], [memory(Mb)], [hdd(Gb)]) VALUES (1600, 2000, 500);
INSERT INTO PC ([cpu(MHz)], [memory(Mb)], [hdd(Gb)]) VALUES (2400, 3000, 800);
INSERT INTO PC ([cpu(MHz)], [memory(Mb)], [hdd(Gb)]) VALUES (3200, 3000, 1200);
INSERT INTO PC ([cpu(MHz)], [memory(Mb)], [hdd(Gb)]) VALUES (2400, 2000, 500);

--1) Тактовые частоты CPU тех компьютеров, у которых объем памяти 3000 Мб. Вывод: id, cpu, memory

SELECT id, [cpu(MHz)], [memory(Mb)] FROM PC
WHERE [memory(Mb)] = 3000;

--2) Минимальный объём жесткого диска, установленного в компьютере на складе. Вывод: hdd

SELECT MIN([hdd(Gb)]) FROM PC
ORDER BY [hdd(Gb)];

--3) Количество компьютеров с минимальным объемом жесткого диска, доступного на складе. Вывод: count, hdd

SELECT COUNT([hdd(Gb)]), MIN([hdd(Gb)]) 
FROM PC
WHERE [hdd(Gb)] = ( SELECT MIN([hdd(Gb)]) FROM PC )
GROUP BY [hdd(Gb)];

--2. (#30) Есть таблица следующего вида:

CREATE TABLE track_downloads ( 
      download_id INTEGER NOT NULL UNIQUE, 
      track_id INTEGER NOT NULL, 
      user_id INTEGER NOT NULL, 
      download_time TIMESTAMP NOT NULL DEFAULT 0, 
       
      PRIMARY KEY (download_id AUTOINCREMENT) 
    ); 

INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (1, 1, '2010-11-18');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (2, 2, '2010-11-19');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (3, 1, '2010-11-19');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (4, 1, '2010-11-19');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (5, 1, '2010-11-19');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (6, 2, '2010-11-19');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (7, 3, '2010-11-19');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (8, 4, '2010-11-19');
INSERT INTO track_downloads (track_id, user_id, download_time ) VALUES (9, 5, '2010-11-20');

-- Напишите SQL-запрос, возвращающий все пары (download_count, user_count), 
--    удовлетворяющие следующему условию: 
--    user_count — общее ненулевое число пользователей, сделавших 
--    ровно download_count скачиваний 19 ноября 2010 года.


SELECT SUM(download_count), count(user_id)
FROM (
	SELECT user_id, count(download_id) as download_count
	FROM track_downloads
	WHERE download_time  = '2010-11-19'
	GROUP BY user_id);

--3. (#10) Опишите разницу типов данных DATETIME и TIMESTAMP

--DATETIME
--Хранит время в виде целого числа вида YYYYMMDDHHMMSS, используя для этого 8 байтов. 
--Это время не зависит от временной зоны. Оно всегда отображается при выборке точно так же, 
--как было сохранено, независимо от того какой часовой пояс установлен.

--TIMESTAMP
--Хранит 4-байтное целое число, равное количеству секунд, прошедших с полуночи 1 января 1970 года 
--по усреднённому времени Гринвича (т.е. нулевой часовой пояс, точка отсчёта часовых поясов). 
--При получении из базы отображается с учётом часового пояса. Часовой пояс может быть задан 
--в операционной системе, глобальных настройках или в конкретной сессии. Cохраняется всегда 
--количество секунд по UTC (универсальное координированное время, солнечное время на меридиане Гринвича), 
--а не по локальному часовому поясу.


--4.(#20)  Необходимо создать таблицу студентов (поля id, name) и таблицу курсов (поля id, name). 
--Каждый студент может посещать несколько курсов. Названия курсов и имена студентов - произвольны.

CREATE TABLE "student" (
	"id_student"	INTEGER NOT NULL UNIQUE,
	"name"		TEXT NOT NULL,
	PRIMARY KEY("id_student" AUTOINCREMENT)
);

CREATE TABLE "course" (
	"id_course"	INTEGER NOT NULL UNIQUE,
	"name"		TEXT NOT NULL,
	PRIMARY KEY("id_course" AUTOINCREMENT)
);

CREATE TABLE "enrollment_in_course" (
	"id_enrollment"	INTEGER NOT NULL UNIQUE,
	"id_course"	INTEGER NOT NULL,
	"id_student"	INTEGER NOT NULL,
	PRIMARY KEY("id_enrollment" AUTOINCREMENT)
);

INSERT INTO student (name) VALUES ('Иван');
INSERT INTO student (name) VALUES ('Петр');
INSERT INTO student (name) VALUES ('Дарья');
INSERT INTO student (name) VALUES ('Анна');
INSERT INTO student (name) VALUES ('Анастасия');
INSERT INTO student (name) VALUES ('Владимир');
INSERT INTO student (name) VALUES ('Дмитрий');

INSERT INTO course (name) VALUES ('Английский язык');
INSERT INTO course (name) VALUES ('Подготовка к ЕГЭ');
INSERT INTO course (name) VALUES ('Подготовка к ОГЭ');

INSERT INTO enrollment_in_course (id_course, id_student) VALUES (1, 2);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (1, 4);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (1, 5);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (1, 6);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (1, 1);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (1, 3);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (1, 7);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (2, 1);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (2, 3);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (2, 4);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (3, 2);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (3, 7);
INSERT INTO enrollment_in_course (id_course, id_student) VALUES (3, 7);

-- 1. отобразить количество курсов, на которые ходит более 5 студентов
SELECT count(id_course)
FROM(
	SELECT id_course, id_student
	FROM enrollment_in_course
	GROUP by id_course
	HAVING count(DISTINCT id_student) >= 5);

--2. отобразить все курсы, на которые записан определенный студент.

SELECT student.name, course.name FROM course
INNER JOIN enrollment_in_course ON enrollment_in_course.id_course = course.id_course
INNER JOIN student ON student.id_student = enrollment_in_course.id_student
ORDER BY student.name;

--5. (5#) Может ли значение в столбце(ах), на который наложено ограничение foreign key, равняться null? 
--Привидите пример. 

--Может, если значение не объявлено ограничение NOT NULL

CREATE TABLE "first_table"(
	"id_first_table" 	INTEGER
);

CREATE TABLE "second_table"(
	"id_second_table" 	INTEGER,
	"id_first_table" 	INTEGER,

	FOREIGN KEY("id_first_table" ) REFERENCES "first_table"("id_first_table")
);

INSERT INTO first_table ("id_first_table") VALUES (null);

INSERT INTO second_table ("id_second_table", "id_first_table") VALUES (1, null);

--6. (#15) Как удалить повторяющиеся строки с использованием ключевого слова Distinct?
-- Приведите пример таблиц с данными и запросы. 

--Чтобы не выводить повторяющиеся строки в результирующей таблице, которую мы получаем в результате
--SQL запроса SELECT, у нас есть модификатор DISTINCT. Мы пишем SELECT DISTINCT, а библиотека SQLite3 
--исключает дубликаты строк в результате выборки. Хотя стоит добавить, что команда SELECT имеет 
--два модификатора: ALL и DISTINCT. SQLite по умолчанию считает, что мы используем значение ALL, 
--когда делаем выборку данных из базы данных.

--ALL
SELECT ALL id_course, id_student 
FROM enrollment_in_course;

--DISTINCT 
SELECT DISTINCT id_course, id_student 
FROM enrollment_in_course;


-- 7. (#10) Есть две таблицы:
-- users - таблица с пользователями (users_id, name)
-- orders - таблица с заказами (orders_id, users_id, status)

CREATE TABLE "users" (
	"users_id"	INTEGER NOT NULL UNIQUE,
	"name"	INTEGER NOT NULL,
	PRIMARY KEY("users_id" AUTOINCREMENT)
);

INSERT INTO users ("name") VALUES ('Иван');
INSERT INTO users ("name") VALUES ('Анастасия');
INSERT INTO users ("name") VALUES ('Ярослав');
INSERT INTO users ("name") VALUES ('Екатерина');

CREATE TABLE "orders" (
	"orders_id"	INTEGER NOT NULL UNIQUE,
	"users_id"	INTEGER NOT NULL,
	"status"	INTEGER NOT NULL,
	PRIMARY KEY("orders_id" AUTOINCREMENT)
);

INSERT INTO orders ("users_id", "status") VALUES (1, 0);
INSERT INTO orders ("users_id", "status") VALUES (2, 1);
INSERT INTO orders ("users_id", "status") VALUES (3, 1);
INSERT INTO orders ("users_id", "status") VALUES (4, 1);
INSERT INTO orders ("users_id", "status") VALUES (2, 1);
INSERT INTO orders ("users_id", "status") VALUES (2, 1);
INSERT INTO orders ("users_id", "status") VALUES (2, 1);
INSERT INTO orders ("users_id", "status") VALUES (2, 1);
INSERT INTO orders ("users_id", "status") VALUES (3, 0);
INSERT INTO orders ("users_id", "status") VALUES (3, 1);
INSERT INTO orders ("users_id", "status") VALUES (3, 1);
INSERT INTO orders ("users_id", "status") VALUES (3, 1);
INSERT INTO orders ("users_id", "status") VALUES (3, 1);

--1) Выбрать всех пользователей из таблицы users, у которых ВСЕ записи в таблице orders имеют status = 0

SELECT users.name FROM users
INNER JOIN orders ON orders.users_id = users.users_id
WHERE orders.users_id NOT IN (
	SELECT users_id
	FROM orders 
	WHERE status = 0 
	GROUP BY users_id)
GROUP BY users.name;

--2) Выбрать всех пользователей из таблицы users, у которых больше 5 записей в таблице orders имеют status = 1

SELECT users.name 
FROM users
INNER JOIN orders ON orders.users_id = users.users_id
WHERE users.users_id IN (
	SELECT users_id FROM orders 
	WHERE status = 1
	GROUP BY users_id
	HAVING count(users_id) >= 5)
GROUP BY users.name;

--WHERE сначала выбирает строки, а затем группирует их и вычисляет агрегатные функции 
--(таким образом, она отбирает строки для вычисления агрегатов), HAVING отбирает строки 
--групп после группировки и вычисления агрегатных функций. Как следствие, предложение 
--WHERE не должно содержать агрегатных функций. редложение HAVING, напротив, всегда 
--содержит агрегатные функции. (Строго говоря, вы можете написать предложение HAVING, 
--не используя агрегаты, но это редко бывает полезно. То же самое условие может работать 
--более эффективно на стадии WHERE.)

-- чтобы полностью проверить условие, нужно точно группировать, WHERE просто проверит 
-- есть такое значение или нет и выведет те, у которых есть

--HAVING же уже работает с агрегирующими функциями, то есть мы сгруппировали, посчитали 
--нужной функцией (минимальное значение в вашем случае), а HAVING уже выдал с условием этого подсчета


