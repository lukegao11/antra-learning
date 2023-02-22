# Understanding Data Types


## Test your Knowledge


### 1. What type would you choose for the following “numbers”?


* A person’s telephone number 

    *string*

* A person’s height

   *double*

* A person’s age

   *int*

* A person’s gender (Male, Female, Prefer Not To Answer)

   *string*

* A person’s salary

   *decimal*

* A book’s ISBN

   *string*

* A book’s price

   *decimal*

* A book’s shipping weight

   *double*

* A country’s population

   *int*

* The number of stars in the universe

   *BigInteger*

* The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)

   *int*

### 2. What are the difference between value type and reference type variables? What is boxing and unboxing?

   *Value types hold their data directly in memory, while reference types hold a reference to the data's location in memory. Value types include simple types such as int, bool, float, and char, as well as more complex types such as structs and enums. Value types are stored on the stack and are passed by value.*

   *Reference types include classes, interfaces, arrays, and delegates. Reference types are stored on the heap and are passed by reference. When you assign a reference type to a variable, you are actually assigning a reference to the object's location in memory, rather than copying the object itself.*

   *Boxing and unboxing are operations that allow you to convert between value types and reference types. Boxing is the process of converting a value type to a reference type by wrapping it in an object. Unboxing is the process of converting a reference type that was previously boxed back to its original value type.*

   *Boxing and unboxing can have a performance cost because they involve creating and destroying objects on the heap, which can be time-consuming. Therefore, it's important to use boxing and unboxing sparingly and only when necessary.*

### 3. What is meant by the terms managed resource and unmanaged resource in .NET

*Managed resources are automatically tracked by the .NET garbage collector and are released when they are no longer needed, which helps to prevent memory leaks and other resource-related issues.*

*On the other hand, unmanaged resources are resources that are not controlled by the .NET runtime environment. Examples of unmanaged resources include system resources like window handles, graphics device interface (GDI) objects, COM objects, and other external resources.*




### 4. Whats the purpose of Garbage Collector in .NET?

*The purpose of the Garbage Collector (GC) in .NET is to automatically manage the allocation and deallocation of memory for managed objects.*

*In .NET, when a new object is created, the GC allocates memory to store the object and tracks the object's location in memory. As the application continues to execute, the GC periodically checks which objects are no longer in use (i.e. are no longer referenced by any other object in the application) and releases the memory allocated for those objects.*















# Controlling Flow and Converting Types


## Test your Knowledge


### 1. What happens when you divide an int variable by 0?

   *When you divide an int variable by 0 in C#, you will get a runtime exception "System.DivideByZeroException". This is because dividing any number by zero is undefined and it results in an error in mathematics.*

### 2. What happens when you divide a double variable by 0?

   *When you divide a double variable by 0 in C#, the result is a special value called "infinity" represented by the constant Double.PositiveInfinity or Double.NegativeInfinity depending on the sign of the dividend.*

   *For example, if you try to evaluate the expression double result = 1.0 / 0.0;, the variable result will be assigned the value Double.PositiveInfinity.*

   *If you divide a negative number by 0, the result will be negative infinity, for example: double result = -1.0 / 0.0; will give Double.NegativeInfinity.*

   *It is also possible to get "not-a-number" (NaN) as the result of a floating-point division by 0 in some cases, for example when dividing 0 by 0.*

### 3. What happens when you overflow an int variable, that is, set it to a value beyond its range?

   *when an int variable is assigned a value beyond its range, an overflow exception is thrown. An overflow exception occurs when the result of an arithmetic operation exceeds the maximum or minimum value that can be stored in the variable's data type.*

   *For example, the maximum value that an int can hold is 2,147,483,647. If you try to assign a value greater than that, an overflow exception will occur. Similarly, the minimum value an int can hold is -2,147,483,648, so if you try to assign a value less than that, an overflow exception will also occur.*


### 4. What is the difference between x = y++; and x = ++y;?

   *x = y++ is a post-increment operation, where the value of y is first assigned to x, and then y is incremented by 1. This means that the original value of y is used in the assignment of x.*

   *x = ++y is a pre-increment operation, where y is first incremented by 1, and then the result is assigned to x. This means that the incremented value of y is used in the assignment of x.*

### 5. What is the difference between break, continue, and return when used inside a loop statement?

   ***break** statement: When used inside a loop statement, the break statement causes the loop to terminate immediately and the control is transferred to the next statement after the loop.*

   ***continue** statement: When used inside a loop statement, the continue statement skips the current iteration of the loop and goes to the next iteration.*

   ***return** statement: When used inside a loop, the return statement terminates the entire method and returns the specified value (if any).*


### 6. What are the three parts of a for statement and which of them are required?

   ***Initialization**: This is the statement that is executed before the loop begins. It usually initializes the loop counter variable. This part is optional and can be omitted if the loop counter variable has already been initialized before the loop.*

   ***Condition**: This is a Boolean expression that is evaluated before each iteration of the loop. If the condition is true, the loop continues. If the condition is false, the loop terminates. This part is required.*

   ***Iteration**: This is the statement that is executed at the end of each iteration of the loop. It usually updates the loop counter variable. This part is optional and can be omitted if the loop counter variable is not used to control the loop.*

### 7. What is the difference between the = and == operators?

   *The = operator is an assignment operator, which is used to assign a value to a variable. For example, int x = 10; assigns the value 10 to the variable x.*

   *The == operator is a comparison operator, which is used to compare the equality of two values. For example, if (x == 10) checks if the value of x is equal to 10.*

### 8. Does the following statement compile? for ( ; true; ) ;

   *Yes, the statement for ( ; true; ) will compile. It creates an infinite loop with an empty initialization and no condition for termination, with the loop body executing repeatedly as long as the true condition remains true.*

### 9. What does the underscore _ represent in a switch expression?

   *The underscore (_) character replaces the default keyword to signify that it should match anything if reached. It matches any value that does not match the previous cases.*
   

### 10. What interface must an object implement to be enumerated over by using the foreach statement?

*In C#, an object must implement the IEnumerable or IEnumerable<T> interface to be enumerated over using the foreach statement.*
*The IEnumerable interface includes the GetEnumerator method that returns an IEnumerator object. The IEnumerator object includes the MoveNext method and the Current property that are used to iterate over the collection. The IEnumerable<T> interface is a generic version of IEnumerable, and it allows strongly typed enumeration over the collection.*
