/*Homework1 -- Guanqun Gao*/
USE AdventureWorks2019
GO

--1. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter. 

SELECT p.ProductID, p.Name, p.Color, p.ListPrice
FROM Production.Product AS p

--2. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, excludes the rows that ListPrice is 0.

SELECT p.ProductID, p.Name, p.Color, p.ListPrice
FROM Production.Product AS p
WHERE p.ListPrice <> 0

--3. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are NULL for the Color column.

SELECT p.ProductID, p.Name, p.Color, p.ListPrice
FROM Production.Product AS p
WHERE p.Color is Null

--4. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the Color column.

SELECT p.ProductID, p.Name, p.Color, p.ListPrice
FROM Production.Product AS p
WHERE p.Color is not Null

--5. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero.

SELECT p.ProductID, p.Name, p.Color, p.ListPrice
FROM Production.Product AS p
WHERE p.Color is not Null 
AND p.ListPrice > 0

--6. Write a query that concatenates the columns Name and Color from the Production.Product table by excluding the rows that are null for color.

SELECT CONCAT(p.Name, p.Color) AS "Product Name with Color"
FROM Production.Product AS p
WHERE p.Color is not Null 
AND p.ListPrice > 0


--7. Write a query that generates the following result set  from Production.Product:

SELECT p.Name AS NAME, p.Color AS COLOR
FROM Production.Product AS p
WHERE p.Name LIKE '%Crankarm' or p.Name LIKE 'Chainring%'
ORDER BY p.Name DESC

--8. Write a query to retrieve the to the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500

SELECT p.ProductID, p.Name
FROM Production.Product AS p
WHERE p.ProductID BETWEEN 400 AND 500

--9. Write a query to retrieve the to the columns  ProductID, Name and color from the Production.Product table restricted to the colors black and blue

SELECT p.ProductID, p.Name
FROM Production.Product AS p
WHERE p.ProductID BETWEEN 400 AND 500


--10. Write a query to get a result set on products that begins with the letter S. 

SELECT p.Name
FROM Production.Product AS p
WHERE p.Name LIKE 'S%'

--11. Write a query that retrieves the columns Name and ListPrice from the Production.Product table. Your result set should look something like the following. Order the result set by the Name column. 

SELECT TOP 6 p.Name, p.ListPrice
FROM Production.Product AS p
WHERE p.Name LIKE 'S%' AND p.ListPrice < 54
ORDER BY p.Name

--12. Write a query that retrieves the columns Name and ListPrice from the Production.Product table. Your result set should look something like the following. Order the result set by the Name column. The products name should start with either 'A' or 'S'

SELECT TOP 5 p.Name, p.ListPrice
FROM Production.Product AS p
WHERE p.Name LIKE '[AS]%' AND p.ListPrice < 160
ORDER BY p.Name

--13. Write a query so you retrieve rows that have a Name that begins with the letters SPO, but is then not followed by the letter K. After this zero or more letters can exists. Order the result set by the Name column.

SELECT *
FROM Production.Product AS p
WHERE p.Name LIKE 'SPO[^K]%' AND p.ListPrice < 160
ORDER BY p.Name

--14. Write a query that retrieves unique colors from the table Production.Product. Order the results  in descending  manner

SELECT DISTINCT p.Color
FROM Production.Product AS p
WHERE p.Color IS NOT Null
ORDER BY p.Color


--15. Write a query that retrieves the unique combination of columns ProductSubcategoryID and Color from the Production.Product table. Format and sort so the result set accordingly to the following. We do not want any rows that are NULL.in any of the two columns in the result.

SELECT DISTINCT p.ProductSubcategoryID, p.Color
FROM Production.Product AS p
WHERE p.Color IS NOT Null AND p.ProductSubcategoryID IS NOT Null
