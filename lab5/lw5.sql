<<<<<<< HEAD
--2 „®¡ ¢¨« â ¡«¨æë
=======
--2 Ð”Ð¾Ð±Ð°Ð²Ð¸Ð» Ñ‚Ð°Ð±Ð»Ð¸Ñ†Ñ‹
>>>>>>> 3d14738c2350cd9a00389b028916b2766311d70f
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

<<<<<<< HEAD
--3 ¯®¤£®â®¢¨« SQL § ¯à®áë ¤«ï § ¯®«­¥­¨ï â ¡«¨æ ¤ ­­ë¬¨.

INSERT INTO dvd (title, production_year) VALUES ('Œáâ¨â¥«¨: ”¨­ «', 2019);
INSERT INTO dvd (title, production_year) VALUES ('€¢ â à', 2009);
INSERT INTO dvd (title, production_year) VALUES ('‡¢¥§¤­ë¥ ¢®©­ë: à®¡ã¦¤¥­¨¥ á¨«ë', 2015);
INSERT INTO dvd (title, production_year) VALUES ('Œáâ¨â¥â«¨: ‚®©­  ¡¥áª®­¥ç­®áâ¨', 2018);
INSERT INTO dvd (title, production_year) VALUES ('’¨â ­¨ª', 1997);
INSERT INTO dvd (title, production_year) VALUES ('Œ¨à žàáª®£® ¯à¨®¤ ', 2015);
INSERT INTO dvd (title, production_year) VALUES ('Š®à®«ì ‹¥¢', 2019);
INSERT INTO dvd (title, production_year) VALUES ('Œáâ¨â¥«¨', 2012);
INSERT INTO dvd (title, production_year) VALUES ('”®àá ¦ 7', 2015);
INSERT INTO dvd (title, production_year) VALUES ('•®«®¤­¥® á¥à¤æ¥ 2', 2019);
INSERT INTO dvd (title, production_year) VALUES ('—¥à­ ï ¯ ­â¥à ', 2018);
INSERT INTO dvd (title, production_year) VALUES (' ç «®', 2010);
INSERT INTO dvd (title, production_year) VALUES ('Š ª ¯à¨àãç¨âì ¤à ª®­ ', 2010);
INSERT INTO dvd (title, production_year) VALUES ('ƒ ¤ª¨© ï', 2010);

INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Šà á­®¢', 'ˆ£®àì', 8085111111, date('2002-05-10'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES (' ¢¥«', ' ¢«®¢', 9715115693, date('2018-06-03'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('€­â®­', '‘ª¢®àæ®¢', 9401324567, date('2003-05-05'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('€­ áâ á¨ï', '€«¥ªá¥¥¢ ', 9499123456, date('2010-01-12'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('…¢ ', '‚®«ª®¢ ', 9813987654, date('2009-07-07'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('€«¥ªá ­¤à ', 'ˆ¢ ­®¢ ', 9312100000, date('2011-09-10'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('€àâ¥¬', '¨ª®« ¥¢', 9510453627, date('2013-02-02'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('®«¨­ ', 'ãâë«¨­ ', 9310456789, date('2010-01-01'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('…£®à', '¥âà®¢', 9510123456, date('2006-06-06'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('‘¢¥â« ­ ', '’¨å®­®¢ ', 9689123456, date('2009-10-10'));
=======
--3 Ð¿Ð¾Ð´Ð³Ð¾Ñ‚Ð¾Ð²Ð¸Ð» SQL Ð·Ð°Ð¿Ñ€Ð¾ÑÑ‹ Ð´Ð»Ñ Ð·Ð°Ð¿Ð¾Ð»Ð½ÐµÐ½Ð¸Ñ Ñ‚Ð°Ð±Ð»Ð¸Ñ† Ð´Ð°Ð½Ð½Ñ‹Ð¼Ð¸.

INSERT INTO dvd (title, production_year) VALUES ('ÃŒÃ±Ã²Ã¨Ã²Ã¥Ã«Ã¨: Ã”Ã¨Ã­Ã Ã«', 2019);
INSERT INTO dvd (title, production_year) VALUES ('Ã€Ã¢Ã Ã²Ã Ã°', 2009);
INSERT INTO dvd (title, production_year) VALUES ('Ã‡Ã¢Ã¥Ã§Ã¤Ã­Ã»Ã¥ Ã¢Ã®Ã©Ã­Ã»: ÃÃ°Ã®Ã¡Ã³Ã¦Ã¤Ã¥Ã­Ã¨Ã¥ Ã±Ã¨Ã«Ã»', 2015);
INSERT INTO dvd (title, production_year) VALUES ('ÃŒÃ±Ã²Ã¨Ã²Ã¥Ã²Ã«Ã¨: Ã‚Ã®Ã©Ã­Ã  Ã¡Ã¥Ã±ÃªÃ®Ã­Ã¥Ã·Ã­Ã®Ã±Ã²Ã¨', 2018);
INSERT INTO dvd (title, production_year) VALUES ('Ã’Ã¨Ã²Ã Ã­Ã¨Ãª', 1997);
INSERT INTO dvd (title, production_year) VALUES ('ÃŒÃ¨Ã° ÃžÃ°Ã±ÃªÃ®Ã£Ã® Ã¯Ã°Ã¨Ã®Ã¤Ã ', 2015);
INSERT INTO dvd (title, production_year) VALUES ('ÃŠÃ®Ã°Ã®Ã«Ã¼ Ã‹Ã¥Ã¢', 2019);
INSERT INTO dvd (title, production_year) VALUES ('ÃŒÃ±Ã²Ã¨Ã²Ã¥Ã«Ã¨', 2012);
INSERT INTO dvd (title, production_year) VALUES ('Ã”Ã®Ã°Ã±Ã Ã¦ 7', 2015);
INSERT INTO dvd (title, production_year) VALUES ('Ã•Ã®Ã«Ã®Ã¤Ã­Ã¥Ã® Ã±Ã¥Ã°Ã¤Ã¶Ã¥ 2', 2019);
INSERT INTO dvd (title, production_year) VALUES ('Ã—Ã¥Ã°Ã­Ã Ã¿ Ã¯Ã Ã­Ã²Ã¥Ã°Ã ', 2018);
INSERT INTO dvd (title, production_year) VALUES ('ÃÃ Ã·Ã Ã«Ã®', 2010);
INSERT INTO dvd (title, production_year) VALUES ('ÃŠÃ Ãª Ã¯Ã°Ã¨Ã°Ã³Ã·Ã¨Ã²Ã¼ Ã¤Ã°Ã ÃªÃ®Ã­Ã ', 2010);
INSERT INTO dvd (title, production_year) VALUES ('ÃƒÃ Ã¤ÃªÃ¨Ã© Ã¿', 2010);

INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('ÃŠÃ°Ã Ã±Ã­Ã®Ã¢', 'ÃˆÃ£Ã®Ã°Ã¼', 8085111111, date('2002-05-10'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('ÃÃ Ã¢Ã¥Ã«', 'ÃÃ Ã¢Ã«Ã®Ã¢', 9715115693, date('2018-06-03'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ã€Ã­Ã²Ã®Ã­', 'Ã‘ÃªÃ¢Ã®Ã°Ã¶Ã®Ã¢', 9401324567, date('2003-05-05'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ã€Ã­Ã Ã±Ã²Ã Ã±Ã¨Ã¿', 'Ã€Ã«Ã¥ÃªÃ±Ã¥Ã¥Ã¢Ã ', 9499123456, date('2010-01-12'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ã…Ã¢Ã ', 'Ã‚Ã®Ã«ÃªÃ®Ã¢Ã ', 9813987654, date('2009-07-07'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ã€Ã«Ã¥ÃªÃ±Ã Ã­Ã¤Ã°Ã ', 'ÃˆÃ¢Ã Ã­Ã®Ã¢Ã ', 9312100000, date('2011-09-10'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ã€Ã°Ã²Ã¥Ã¬', 'ÃÃ¨ÃªÃ®Ã«Ã Ã¥Ã¢', 9510453627, date('2013-02-02'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('ÃÃ®Ã«Ã¨Ã­Ã ', 'ÃÃ³Ã²Ã»Ã«Ã¨Ã­Ã ', 9310456789, date('2010-01-01'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ã…Ã£Ã®Ã°', 'ÃÃ¥Ã²Ã°Ã®Ã¢', 9510123456, date('2006-06-06'));
INSERT INTO customer (first_name, last_name, passport_code, registration_date) VALUES ('Ã‘Ã¢Ã¥Ã²Ã«Ã Ã­Ã ', 'Ã’Ã¨ÃµÃ®Ã­Ã®Ã¢Ã ', 9689123456, date('2009-10-10'));
>>>>>>> 3d14738c2350cd9a00389b028916b2766311d70f

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

<<<<<<< HEAD
--4. ®¤£®â®¢ìâ¥ SQL § ¯à®á ¯®«ãç¥­¨ï á¯¨áª  ¢á¥å DVD, £®¤ ¢ë¯ãáª  ª®â®àëå 2010, #10 ®âá®àâ¨à®¢ ­­ëå ¢  «ä ¢¨â­®¬ ¯®àï¤ª¥ ¯® ­ §¢ ­¨î DVD.
=======
--4. ÃÃ®Ã¤Ã£Ã®Ã²Ã®Ã¢Ã¼Ã²Ã¥ SQL Ã§Ã Ã¯Ã°Ã®Ã± Ã¯Ã®Ã«Ã³Ã·Ã¥Ã­Ã¨Ã¿ Ã±Ã¯Ã¨Ã±ÃªÃ  Ã¢Ã±Ã¥Ãµ DVD, Ã£Ã®Ã¤ Ã¢Ã»Ã¯Ã³Ã±ÃªÃ  ÃªÃ®Ã²Ã®Ã°Ã»Ãµ 2010, #10 Ã®Ã²Ã±Ã®Ã°Ã²Ã¨Ã°Ã®Ã¢Ã Ã­Ã­Ã»Ãµ Ã¢ Ã Ã«Ã´Ã Ã¢Ã¨Ã²Ã­Ã®Ã¬ Ã¯Ã®Ã°Ã¿Ã¤ÃªÃ¥ Ã¯Ã® Ã­Ã Ã§Ã¢Ã Ã­Ã¨Ã¾ DVD.
>>>>>>> 3d14738c2350cd9a00389b028916b2766311d70f

SELECT * FROM dvd
WHERE dvd.production_year = 2010
ORDER BY title;

<<<<<<< HEAD
--5 ®¤£®â®¢ìâ¥ SQL § ¯à®á ¤«ï ¯®«ãç¥­¨ï á¯¨áª  DVD ¤¨áª®¢, ª®â®àë¥ ¢ ­ áâ®ïé¥¥ ¢à¥¬ï #10 ­ å®¤ïâáï ã ª«¨¥­â®¢
=======
--5 ÃÃ®Ã¤Ã£Ã®Ã²Ã®Ã¢Ã¼Ã²Ã¥ SQL Ã§Ã Ã¯Ã°Ã®Ã± Ã¤Ã«Ã¿ Ã¯Ã®Ã«Ã³Ã·Ã¥Ã­Ã¨Ã¿ Ã±Ã¯Ã¨Ã±ÃªÃ  DVD Ã¤Ã¨Ã±ÃªÃ®Ã¢, ÃªÃ®Ã²Ã®Ã°Ã»Ã¥ Ã¢ Ã­Ã Ã±Ã²Ã®Ã¿Ã¹Ã¥Ã¥ Ã¢Ã°Ã¥Ã¬Ã¿ #10 Ã­Ã ÃµÃ®Ã¤Ã¿Ã²Ã±Ã¿ Ã³ ÃªÃ«Ã¨Ã¥Ã­Ã²Ã®Ã¢
>>>>>>> 3d14738c2350cd9a00389b028916b2766311d70f

SELECT dvd.dvd_id, dvd.title, dvd.production_year FROM dvd
INNER JOIN offer ON offer.dvd_id = dvd.dvd_id
WHERE 
	offer.return_date IS NULL;

<<<<<<< HEAD
--6  ¯¨è¨â¥ SQL § ¯à®á ¤«ï ¯®«ãç¥­¨ï á¯¨áª  ª«¨¥­â®¢, ª®â®àë¥ ¡à «¨ ª ª¨¥-«¨¡® DVD 
--#10 ¤¨áª¨ ¢ â¥ªãé¥¬ £®¤ã. ‚ à¥§ã«ìâ â å § ¯à®á  ­¥®¡å®¤¨¬® â ª¦¥ ®âà §¨âì ª ª¨¥ ¤¨áª¨ 
--¡à «¨ ª«¨¥­âë.
=======
--6 ÃÃ Ã¯Ã¨Ã¸Ã¨Ã²Ã¥ SQL Ã§Ã Ã¯Ã°Ã®Ã± Ã¤Ã«Ã¿ Ã¯Ã®Ã«Ã³Ã·Ã¥Ã­Ã¨Ã¿ Ã±Ã¯Ã¨Ã±ÃªÃ  ÃªÃ«Ã¨Ã¥Ã­Ã²Ã®Ã¢, ÃªÃ®Ã²Ã®Ã°Ã»Ã¥ Ã¡Ã°Ã Ã«Ã¨ ÃªÃ ÃªÃ¨Ã¥-Ã«Ã¨Ã¡Ã® DVD 
--#10 Ã¤Ã¨Ã±ÃªÃ¨ Ã¢ Ã²Ã¥ÃªÃ³Ã¹Ã¥Ã¬ Ã£Ã®Ã¤Ã³. Ã‚ Ã°Ã¥Ã§Ã³Ã«Ã¼Ã²Ã Ã²Ã Ãµ Ã§Ã Ã¯Ã°Ã®Ã±Ã  Ã­Ã¥Ã®Ã¡ÃµÃ®Ã¤Ã¨Ã¬Ã® Ã²Ã ÃªÃ¦Ã¥ Ã®Ã²Ã°Ã Ã§Ã¨Ã²Ã¼ ÃªÃ ÃªÃ¨Ã¥ Ã¤Ã¨Ã±ÃªÃ¨ 
--Ã¡Ã°Ã Ã«Ã¨ ÃªÃ«Ã¨Ã¥Ã­Ã²Ã».
>>>>>>> 3d14738c2350cd9a00389b028916b2766311d70f

SELECT customer.customer_id, customer.first_name, customer.last_name, 
customer.passport_code, customer.registration_date, dvd.dvd_id, dvd.title
FROM customer 
INNER JOIN offer ON offer.customer_id = customer.customer_id
INNER JOIN dvd ON dvd.dvd_id = offer.dvd_id
WHERE 	
	strftime('%Y', DATE('NOW')) = strftime('%Y', offer.offer_date);

