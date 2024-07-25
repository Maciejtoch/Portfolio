CREATE DATABASE Strona;

USE Strona;


CREATE TABLE Users (
	id SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    password VARCHAR(100) NOT NULL,
    role VARCHAR(30) NOT NULL 
    ) ; 
    
SELECT * FROM Users ; 

INSERT INTO Users (username, email, password, role)
VALUES
('User1', 'user1@email.com', 'user1password', 'user'),
('User2', 'user2@email.com', 'user2password', 'user'),
('User3', 'user3@email.com', 'user3password', 'user'),
('User4', 'user4@email.com', 'user4password', 'user'),
('User5', 'user5@email.com', 'user5password', 'user'),
('User6', 'user6@email.com', 'user6password', 'user'),
('User7', 'user7@email.com', 'user7password', 'user'),
('User8', 'user8@email.com', 'user8password', 'user'),
('User9', 'user9@email.com', 'user9password', 'user'),
('User10', 'user10@email.com', 'user10password', 'user'),
('User11', 'user11@email.com', 'user11password', 'user'),
('User12', 'user12@email.com', 'user12password', 'user'),
('Marianna', 'marianna123@email.com', 'kochampieski1', 'loyal_customer'),
('Wiktoria', 'wikusia1999@email.com', 'kochampieski2', 'loyal_customer'),
('Malgosia', 'malgosia33@email.com', 'kochampieski3', 'loyal_customer'),
('Sonia', 'sonia123@email.com', 'kochampieski4', 'loyal_customer'),
('Marianna', 'marianna53454@email.com', 'kochamkotki15', 'problematic'),
('Wiktoria', 'wikunia@email.com', 'kochamkotki15', 'problematic'),
('Malgosia', 'mmalgosia@email.com', 'kochamkotki15', 'problematic'),
('Paulina', 'paula123@email.com', 'kochamkotki15', 'problematic'),
('Julka', 'juli4234@email.com', 'kochamkotki15', 'problematic') ; 

ALTER TABLE Users DROP PRIMARY KEY;

ALTER TABLE Users MODIFY COLUMN id INT AUTO_INCREMENT PRIMARY KEY;

DESC Users;

ALTER TABLE Users DROP COLUMN role ; 

CREATE TABLE Purchase_history (
    id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    email VARCHAR(50) NOT NULL,
    product_name VARCHAR(100) NOT NULL,
    purchase_date DATE NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    status VARCHAR(25) NOT NULL,
    FOREIGN KEY (user_id) REFERENCES Users(id)
);

SELECT * FROM Purchase_history ; 

ALTER TABLE Purchase_history
DROP COLUMN email ; 


INSERT INTO Purchase_history (user_id, product_name, purchase_date, price, status)
VALUES 
	(1, 'plan_treningowy', '2024-07-07', '200', 'completed'),
    (2, 'plan_treningowy', '2024-07-08', '200', 'canceled'),
    (3, 'dieta', '2024-07-09', '150', 'pending'),
    (7, 'dieta', '2024-07-07', '150', 'completed'),
    (10, 'plan_fizjo', '2024-07-01', '250', 'pending');
    
CREATE TABLE Payments (
	id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    payment_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    status VARCHAR(25) NOT NULL,
    payment_method VARCHAR(50) NOT NULL,
    transaction_id VARCHAR(100),
    FOREIGN KEY (user_id) REFERENCES Users(id) ) ;
    
SELECT * FROM Payments ; 

ALTER TABLE Payments 
MODIFY COLUMN status VARCHAR(25) AFTER payment_method; 

CREATE TABLE Products (
	id INT AUTO_INCREMENT PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
	category VARCHAR(25) NOT NULL );
    
SELECT * FROM Products ;

CREATE TABLE Reviews (
	id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    product_id INT NOT NULL,
    rating INT NOT NULL,
    review_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES Users(id),
    FOREIGN KEY (product_id) REFERENCES Products(id) );
    
SELECT * FROM Reviews ;


CREATE TABLE Sessions (
	id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    session_token VARCHAR(255) NOT NULL,
    expiration DATETIME NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UNIQUE (session_token),
    FOREIGN KEY (user_id) REFERENCES Users(id)  );
    
SELECT * FROM Sessions ; 
    

    


