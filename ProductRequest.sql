CREATE TABLE products (
	id INT PRIMARY KEY,
	"name" varchar(50)
);

INSERT INTO products
VALUES
	(1, 'milk'),
	(2, 'pork'),
	(3, 'The Adventures of Sherlock Holmes'),
	(4, 'Iphone 11'),
	(5, 'null1'),
	(6, 'null2');


CREATE TABLE categories (
	id INT PRIMARY KEY,
	"name" varchar(50)
);

INSERT INTO categories
VALUES
	(1, 'milk products'),
	(2, 'meat '),
	(3, 'book'),
	(4, 'phone');


CREATE TABLE prod_cat (
	prod_id INT FOREIGN KEY REFERENCES products(id),
	cat_id INT FOREIGN KEY REFERENCES categories(id),
	PRIMARY KEY (prod_id, cat_id)
);

INSERT INTO prod_cat
VALUES
	(1, 1),
	(2, 2),
	(3, 3),
	(4, 4);

SELECT products.name, categories.name FROM products LEFT JOIN prod_cat ON products.id = prod_cat.prod_id LEFT JOIN categories ON prod_cat.cat_id = categories.id