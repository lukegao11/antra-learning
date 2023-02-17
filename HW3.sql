/*Assignment 3 - SQL SUBQUERIES*/
/*Guanqun Gao*/
USE Northwind
Go

--1. List all cities that have both Employees and Customers.

SELECT DISTINCT e.City
FROM Employees e
JOIN Customers c
ON e.City = c.City

--2. List all cities that have Customers but no Employee.
	
--a. Use sub-query

SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (
	SELECT DISTINCT e.City
	FROM Employees e
)

--b. Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c
EXCEPT
SELECT DISTINCT e.City
FROM Employees e

--3. List all products and their total order quantities throughout all orders.

SELECT p.ProductName, SUM(od.Quantity) AS "Total Quantity"
FROM [Order Details] AS od
JOIN Products p
ON od.ProductID = p.ProductID
GROUP BY p.ProductID, p.ProductName;


--4. List all Customer Cities and total products ordered by that city.

WITH QuantityCTE
AS(
	SELECT od.OrderID, SUM(od.Quantity) AS "Total Quantity by Order"
	FROM [Order Details] AS od
	GROUP BY od.OrderID
)
SELECT c.City, SUM(cte.[Total Quantity by Order]) AS "Total Quantity by City"
FROM QuantityCTE AS cte
JOIN Orders o
ON cte.OrderID = o.OrderID
JOIN Customers c
ON c.CustomerID = o.CustomerID
GROUP BY c.City;

--5. List all Customer Cities that have at least two customers.

--a. Use union
(SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > 2)
UNION
(SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) = 2)


--b. Use sub-query and no union

SELECT DISTINCT c.City
FROM Customers c, (SELECT cu.City, cu.CustomerID FROM Customers cu) AS cus
WHERE cus.CustomerID != c.CustomerID AND c.City = cus.City



--6. List all Customer Cities that have ordered at least two different kinds of products.

WITH CountCTE
AS(
	SELECT od.OrderID, COUNT(ProductID) AS "Product Type Count by Order"
	FROM [Order Details] od
	GROUP BY od.OrderID
)
SELECT c.City, SUM(cte.[Product Type Count by Order]) AS "Product Type Count by City"
FROM CountCTE AS cte
JOIN Orders o
ON cte.OrderID = o.OrderID
JOIN Customers c
ON c.CustomerID = o.CustomerID
GROUP BY c.City
HAVING SUM(cte.[Product Type Count by Order])>=2;

--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.

SELECT c.ContactName
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity


--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

WITH TopCTE
AS(
	SELECT TOP 5 ProductID, ROUND(AVG(UnitPrice),2) AS "Average Price"
	FROM [Order Details]
	GROUP BY ProductID
	ORDER BY SUM(Quantity) DESC
)
SELECT dt.ProductID, dt.City, cte.[Average Price]
FROM
(	SELECT od.ProductID, c.City, SUM(od.Quantity) AS "Product Quantity by City", ROW_NUMBER() OVER (PARTITION BY od.ProductID ORDER BY SUM(od.Quantity) DESC) AS rn
	FROM [Order Details] od
	JOIN Orders o
	ON od.OrderID = o.OrderID
	JOIN Customers c
	ON c.CustomerID = o.CustomerID
	GROUP BY od.ProductID, c.City) dt
JOIN TopCTE cte
ON cte.ProductID = dt.ProductID
WHERE dt.rn = 1


--9. List all cities that have never ordered something but we have employees there.
--a. Use sub-query

SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
	SELECT DISTINCT c.City
	FROM [Order Details] od
	JOIN Orders o
	ON od.OrderID = o.OrderID
	JOIN Customers c
	ON c.CustomerID = o.CustomerID
)

--b. Do not use sub-query

SELECT DISTINCT e.City
FROM Employees e
EXCEPT 
SELECT DISTINCT c.City
FROM [Order Details] od
JOIN Orders o
ON od.OrderID = o.OrderID
JOIN Customers c
ON c.CustomerID = o.CustomerID



--10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)

-- it does not exist

WITH firstCTE AS(
	SELECT TOP 1 c.City
	FROM [Order Details] od
	JOIN Orders o ON od.OrderID = o.OrderID
	JOIN Customers c ON c.CustomerID = o.CustomerID
	GROUP BY c.City
	ORDER BY SUM(od.Quantity) DESC
), 
secondCTE AS (
	SELECT TOP 1 e.City
	FROM Orders o
	JOIN Employees e ON e.EmployeeID = o.EmployeeID
	GROUP BY e.City
	ORDER BY COUNT(o.OrderID) DESC
)
SELECT *
FROM firstCTE cte1
JOIN secondCTE cte2 ON cte1.City = cte2.City








--11. How do you remove the duplicates record of a table?

-- use DISTINCT operator in SELECT





































