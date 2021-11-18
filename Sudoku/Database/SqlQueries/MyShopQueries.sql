USE MyShop

--> Query 1 : Select product with product name that begins with ‘C’.

SELECT ProductName FROM Products
WHERE ProductName LIKE 'C%'

--> Query 2 : Select product with the smallest price.

SELECT * FROM Products
WHERE Price = (SELECT MIN(Price) FROM Products)

--> Query 3 : Select cost of all products from the USA.

SELECT SUM(Price) AS TotalCost FROM Products p
JOIN Suppliers s ON p.SupplierId = s.SupplierId
WHERE s.Country LIKE 'USA'

--> Query 4 : Select suppliers that supply Condiments.

SELECT s.SupplierId, s.SupplierName, s.City, s.Country FROM Suppliers s
JOIN Products p ON s.SupplierId = p.ProductId
JOIN Categories c ON c.CategoryId = p.CategoryId
WHERE c.CategoryName LIKE 'Condiments'

--> Query 5 : Add to database new supplier with name
INSERT Suppliers VALUES
('Norske Meierier','Lviv', 'Ukraine')

INSERT Products VALUES
('Green tea'
,(SELECT SupplierId FROM Suppliers WHERE SupplierName LIKE 'Norske Meierier')
,(SELECT CategoryId FROM Categories WHERE CategoryName LIKE 'Beverages'), 10)