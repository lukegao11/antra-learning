USE AdventureWorks2019
GO
--1. How many products can you find in the Production.Product table?
SELECT COUNT(p.ProductID) AS "Product Count"
FROM Production.Product AS p


--2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.

SELECT COUNT(p.ProductID) AS "Product Count"
FROM Production.Product AS p
WHERE p.ProductSubcategoryID IS NOT NULL

--3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.

SELECT p.ProductSubcategoryID, COUNT(p.ProductID) AS CountedProducts
FROM Production.Product AS p
WHERE p.ProductSubcategoryID IS NOT NULL
GROUP BY p.ProductSubcategoryID

--4. How many products that do not have a product subcategory.

SELECT COUNT(p.ProductID) AS "Product Count"
FROM Production.Product AS p
WHERE p.ProductSubcategoryID IS NULL

--5. Write a query to list the sum of products quantity in the Production.ProductInventory table.

SELECT SUM(p.Quantity) AS TheSum
FROM Production.ProductInventory as p

--6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.

SELECT p.ProductID, SUM(p.Quantity) AS TheSum
FROM Production.ProductInventory as p
WHERE p.LocationID = 40 AND p.Quantity < 100
GROUP BY p.ProductID


--7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100

SELECT p.Shelf, p.ProductID,  SUM(p.Quantity) AS TheSum
FROM Production.ProductInventory as p
WHERE p.LocationID = 40 AND p.Quantity < 100
GROUP BY p.ProductID, p.Shelf

--8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.

SELECT AVG(p.Quantity) AS TheAvg
FROM Production.ProductInventory as p
WHERE p.LocationID = 10

--9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory

SELECT p.ProductID, p.Shelf, AVG(p.Quantity) AS TheAvg
FROM Production.ProductInventory as p
GROUP BY p.Shelf, p.ProductID

--10. Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory

SELECT p.ProductID, p.Shelf, AVG(p.Quantity) AS TheAvg
FROM Production.ProductInventory as p
WHERE p.Shelf <> 'N/A'
GROUP BY p.Shelf, p.ProductID

--11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.

SELECT p.Class, p.Color, COUNT(p.ProductID) AS TheCount, AVG(p.ListPrice) AS AvgPrice
FROM Production.Product as p
WHERE p.Class IS NOT NULL AND p.Color IS NOT NULL
GROUP BY p.Class, p.Color


--JOIN

--12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.

SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr 
JOIN Person.StateProvince sp 
ON cr.CountryRegionCode = sp.CountryRegionCode

--13 Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr 
JOIN Person.StateProvince sp 
ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name IN ('Germany', 'Canada')





--Using Northwnd Database: (Use aliases for all the Joins)

USE Northwind
GO

--14.  List all Products that has been sold at least once in last 25 years.

WITH ProductCTE
AS
(
	SELECT p.ProductID, p.ProductName, MAX(o.OrderDate) AS "LASTEST PURCHASE DATE"
	FROM Products AS p 
	JOIN [Order Details] AS od 
	ON p.ProductID = od.ProductID
	JOIN Orders AS o
	ON o.OrderID = od.OrderID
	GROUP BY p.ProductID, p.ProductName
)
SELECT ProductID, ProductName, [LASTEST PURCHASE DATE]
FROM ProductCTE AS cte
WHERE DATEDIFF(year, cte.[LASTEST PURCHASE DATE], GETDATE()) <=25
ORDER BY cte.ProductID


--15.  List top 5 locations (Zip Code) where the products sold most.

WITH OrderCTE
AS (
	SELECT TOP 5 o.OrderID, c.CustomerID, c.PostalCode, SUM(Quantity) AS TheSum
	FROM [Order Details] AS od
	JOIN Orders o
	ON o.OrderID = od.OrderID
	JOIN Customers c
	ON c.CustomerID = o.CustomerID
	GROUP BY o.OrderID, c.CustomerID, c.PostalCode
	ORDER BY TheSum DESC
)
SELECT PostalCode
FROM OrderCTE 


--16.  List top 5 locations (Zip Code) where the products sold most in last 25 years.

WITH OrderCTE
AS (
	SELECT TOP 5 o.OrderID, c.CustomerID, c.PostalCode, SUM(Quantity) AS TheSum
	FROM [Order Details] AS od
	JOIN Orders o
	ON o.OrderID = od.OrderID
	JOIN Customers c
	ON c.CustomerID = o.CustomerID
	WHERE DATEDIFF(year, o.OrderDate, GETDATE()) <=25
	GROUP BY o.OrderID, c.CustomerID, c.PostalCode
	ORDER BY TheSum DESC
)
SELECT PostalCode
FROM OrderCTE 



--17.   List all city names and number of customers in that city.  

SELECT c.city AS "City Name", COUNT(c.CustomerID) AS "Customer Count"
FROM Customers c
GROUP BY c.City
ORDER BY [Customer Count] DESC


--18.  List city names which have more than 2 customers, and number of customers in that city

SELECT c.city AS "City Name"
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > 2
ORDER BY COUNT(c.CustomerID) DESC


--19.  List the names of customers who placed orders after 1/1/98 with order date.

SELECT DISTINCT c.ContactName
FROM Customers c 
JOIN Orders o
ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1/1/1998'



--20.  List the names of all customers with most recent order dates

SELECT TOP 4 c.ContactName
FROM Customers c 
JOIN Orders o
ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName
ORDER BY MAX(o.OrderDate) DESC


--21.  Display the names of all customers  along with the  count of products they bought

SELECT c.ContactName AS "Customer Name", SUM(SUMQuant) AS "Total Count"
FROM Orders AS o
JOIN
(
	SELECT od.OrderID, SUM(Quantity) AS "SUMQuant"
	FROM [Order Details] AS od
	GROUP BY od.OrderID
) dt
ON dt.OrderID = o.OrderID
JOIN Customers c
ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName


--22.  Display the customer ids who bought more than 100 Products with count of products.

SELECT o.CustomerID AS "Customer ID", SUM(SUMQuant) AS "Total Count"
FROM Orders AS o
JOIN
(
	SELECT od.OrderID, SUM(Quantity) AS "SUMQuant"
	FROM [Order Details] AS od
	GROUP BY od.OrderID
) dt
ON dt.OrderID = o.OrderID
GROUP BY o.CustomerID
HAVING SUM(SUMQuant) > 100


--23.  List all of the possible ways that suppliers can ship their products. Display the results as below

SELECT *
FROM Suppliers


SELECT *
FROM Shippers


--24.  Display the products order each day. Show Order date and Product Name.

--25.  Displays pairs of employees who have the same job title.

--26.  Display all the Managers who have more than 2 employees reporting to them.

--27.  Display the customers and suppliers by city. The results should have the following columns
































