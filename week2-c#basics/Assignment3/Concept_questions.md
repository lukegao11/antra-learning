# Object-Oriented Programming
## Test your knowledge
### 1. What are the six combinations of access modifier keywords and what do they do? 
public: The public access modifier is the most permissive and allows access from any other class in any package. Public class members can be accessed without any restrictions.

protected: The protected access modifier allows access from within the same package and subclasses in any package. Protected class members can be accessed by classes in the same package or by subclasses of the class in any package.

default (package-private): The default access modifier (also called package-private) allows access from within the same package only. Class members with default access can be accessed by classes in the same package but not by classes in other packages.

private: The private access modifier is the most restrictive and allows access only from within the same class. Private class members cannot be accessed by any other class.
public protected: This combination is not valid because both modifiers are mutually exclusive.

private protected: This combination is also not valid because both modifiers are mutually exclusive.
### 2. What is the difference between the static, const, and readonly keywords when applied to a type member?

static: The static keyword is used to declare a member that belongs to the type itself, rather than to an instance of the type. This means that the member can be accessed without creating an object of the type. For example, a static field can be used to keep track of the number of instances created for a class, or a static method can be used to perform a calculation that doesn't depend on the state of any object.

const: The const keyword is used to declare a constant value that can be used throughout the program. A const member is implicitly static and can't be changed once it's assigned a value. Const members must be initialized with a value at the time of declaration, and that value must be a compile-time constant. This means that const members can only be of a value type, a string, or a null reference.

readonly: The readonly keyword is used to declare a member that can be set only in the constructor of the type, or in the field declaration itself. A readonly member is also implicitly static, but unlike const, it can be of any type that can be assigned a value. A readonly member is initialized when the type is created and can't be changed afterwards.

### 3. What does a constructor do?

 a constructor is a special method that is called when an instance of a class is created. The constructor has the same name as the class and is used to initialize the instance variables (also called fields) of the class with specific values.

### 4. Why is the partial keyword useful?

The partial keyword is useful in a number of scenarios, including:

Large classes: When a class is very large, it can be difficult to navigate and maintain. By splitting the class definition into multiple files, it becomes easier to manage the code and to work with different parts of the class separately.

Code generation: When using tools that generate code automatically, such as Visual Studio's designer tools, the partial keyword can be used to separate the generated code from the manually written code. This allows the generated code to be updated without affecting the custom code.

Team collaboration: When working on a large project with multiple developers, the partial keyword can be used to allow different team members to work on different parts of the class separately. This can improve productivity and reduce conflicts in the code.

Separating concerns: By splitting a class into multiple files, it is possible to separate different concerns or aspects of the class into different files. This can make the code easier to understand and maintain.

The partial keyword allows a class to be split into multiple files, which can improve code organization, enable better team collaboration, and simplify code maintenance.

### 5. What is a tuple?

In C#, a tuple is a data structure that can be used to store a fixed number of values of different types. A tuple is defined as a sequence of elements that are grouped together, and each element can be of a different type.

### 6. What does the C# record keyword do?

the record keyword is a new feature in C# 9.0 that allows developers to define immutable reference types in a more concise and expressive way. Records come with several built-in features that simplify working with data objects, including value-based equality, deconstruction, and with-expressions.

### 7. What does overloading and overriding mean?

Overloading refers to the process of defining multiple methods or constructors with the same name but with different parameters. The compiler uses the number, type, and order of the parameters to determine which method or constructor to invoke. Overloading allows you to create methods or constructors with similar functionality but with different parameter sets.

Overriding, on the other hand, refers to the process of providing a new implementation for a method that is already defined in a base class. The method in the derived class must have the same signature (i.e., name, return type, and parameters) as the method in the base class, and it must be marked with the override keyword. When the derived class is instantiated, the overridden method in the base class is replaced by the new implementation in the derived class.

### 8. What is the difference between a field and a property?

A field is a variable that is declared within a class, struct, or interface, and that holds a value. A property, on the other hand, provides a way to access and modify the values of private fields, and can also provide additional functionality, such as validation or calculation, when getting or setting a value.

### 9. How do you make a method parameter optional?

You can make a method parameter optional by specifying a default value for the parameter. When a default value is specified for a parameter, callers of the method can choose to omit the argument for that parameter, and the default value will be used instead.

### 10. What is an interface and how is it different from abstract class?

An interface is a contract that defines a set of methods, properties, and events that a class must implement. An interface does not provide any implementation for the members that it defines; it only specifies their signatures. A class can implement one or more interfaces to provide the required implementation for the members that they define.

An abstract class, on the other hand, is a class that cannot be instantiated on its own, and must be subclassed to provide implementation for its abstract members. An abstract class can contain both abstract and non-abstract members, and can also provide some default implementation for its non-abstract members. A class can only inherit from one abstract class, but can implement multiple interfaces.

### 11. What accessibility level are members of an interface?

All members of an interface are implicitly public and cannot have any other access modifiers such as private, protected, or internal. This is because an interface is a contract that defines a set of members that a class must implement, and all members of an interface must be accessible to any class that implements the interface.

### 12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.

True

### 13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

True

### 14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method

False

The statement is partially correct. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method that already exists in its base class. However, using the new keyword creates a new, independent implementation of the method in the derived class, and it is not related to the implementation in the base class.

When a method in a derived class is marked with the new keyword, it is creating a new implementation of a method that already exists in the base class, but it is not overriding the base implementation. This means that if a method call is made on an object of the derived class, the implementation in the derived class will be called, even if the method call is made through a reference to the base class.

### 15. True/False. Abstract methods can be used in a normal (non-abstract) class. 

False.

Abstract methods can only exist in abstract classes or interfaces. An abstract method is a method that is declared without any implementation and must be overridden by any non-abstract derived class.

### 16. True/False. Normal (non-abstract) methods can be used in an abstract class. 

True


### 17. True/False. Derived classes can override methods that were virtual in the base class. 

True

### 18. True/False. Derived classes can override methods that were abstract in the base class. 

True

### 19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.

False

### 20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.

False

### 21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.

True

### 22. True/False. A class can have more than one base class.

False

### 23. True/False. A class can implement more than one interface.

True
