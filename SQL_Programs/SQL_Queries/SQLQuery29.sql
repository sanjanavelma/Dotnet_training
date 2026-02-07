CREATE TABLE FoodItem (
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Type VARCHAR(50),
    Price INT
);

INSERT INTO FoodItem VALUES
(1, 'Ice-Cream', 'Dessert', 50),
(2, 'Noodles', 'Fast-Food', 150),
(3, 'Biryani', 'Meal', 250);

CREATE TABLE Food_Delete (
    ID INT,
    Name VARCHAR(50),
    Type VARCHAR(50),
    Price INT,
    DeletedDate DATETIME
);

CREATE or Alter TRIGGER trg_AfterDelete_Food
ON FoodItem
AFTER DELETE
AS
BEGIN
    INSERT INTO Food_Delete
    SELECT ID, Name, Type, Price, GETDATE()
    FROM deleted;
END;

DELETE FROM FoodItem WHERE ID = 1;

select * from FoodItem
select * from Food_Delete