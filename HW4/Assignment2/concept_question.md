# 02 Arrays and Strings


## Test your Knowledge


### 1. When to use String vs. StringBuilder in C# ?

*use a string when you have a fixed sequence of characters that won't change, or when you need to concatenate a small number of strings. On the other hand, you should use a StringBuilder when you need to concatenate a large number of strings or when you need to modify the content of the string.*

### 2. What is the base class for all arrays in C#?

*the base class for all arrays is the System.Array class.*

### 3. How do you sort an array in C#?

***Array.Sort** method sorts the elements of an array in ascending order.*

### 4. What property of an array object can be used to get the total number of elements in an array?

*use the Length property of an array object to get the total number of elements in the array.*

### 5. Can you store multiple data types in System.Array?

*System.Array class can store multiple data types, but all the elements of the array must be of the same type.*

### 6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

*System.Array.CopyTo() method copies the elements of one array to another existing array, while System.Array.Clone() method creates a new array that is a copy of the original array.*

*The new array is a shallow copy, which means that the elements of the new array are references to the same objects as the elements of the original array. If the original array contains reference types, modifying the elements of the new array will also modify the elements of the original array. *
