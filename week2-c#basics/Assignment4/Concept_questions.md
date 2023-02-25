# Generics
## Test your Knowledge
### 1. Describe the problem generics address.

Generics address the problem of code reuse and type safety in programming languages.

Without generics, developers often have to write multiple versions of the same code to handle different data types. This can result in code duplication, which can lead to maintenance and readability issues.

Generics allow developers to create reusable code that can work with multiple types without having to write duplicate code. They provide a way to abstract over types, allowing developers to write functions and data structures that can be used with any type that satisfies certain constraints.

### 2. How would you create a list of strings, using the generic List class?

List<string> stringList = new List<string>();

### 3. How many generic type parameters does the Dictionary class have?

Two generic type parameters. TKey for the type of the keys, and TValue for the type of the values. Here is an example of how to create a Dictionary object that maps strings to integers.
  
### 4. True/False. When a generic class has multiple type parameters, they must all match.

False, when a generic class has multiple type parameters, it is possible to have different types for each parameter, as long as they satisfy the constraints specified in the class definition.
  
### 5. What method is used to add items to a List object?
  
In C#, the add method is defined in the List interface and implemented by the List<T> class. 
  
### 6. Name two methods that cause items to be removed from a List.
  
In C#, the Remove and RemoveAt method is defined in the List interface and implemented by the List<T> class.
  
### 7. How do you indicate that a class has a generic type parameter?
  
You can indicate that a class has a generic type parameter by including the type parameter in angle brackets < > after the class name. 
  
### 8. True/False. Generic classes can only have one generic type parameter.
  
False

### 9. True/False. Generic type constraints limit what can be used for the generic type.
  
True
  
### 10. True/False. Constraints let you use the methods of the thing you are constraining to.

True
  
One of the benefits of using constraints is that they allow you to specify which methods or properties of the generic type argument you can access and use within the generic class or method.

For example, suppose you have a generic class that needs to perform some operation on its type parameter, but that operation requires a certain method to be present on the type. You can use a constraint to ensure that the type parameter has that method.
