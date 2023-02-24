using Week2Assignment3;


//Q1 reverse array
Console.WriteLine("\nQ1");
ReverseArray.GenerateNumbers(10);
int[] numbers = ReverseArray.GenerateNumbers(10);
ReverseArray.PrintNumbers(numbers);
ReverseArray.Reverse(numbers);
ReverseArray.PrintNumbers(numbers);


//Q2.Fibonacci 
Console.WriteLine("\nQ2");
for (int i = 1; i < 11; i++)
{
    Console.Write(Fibonacci.nthFibonacci(i));
    Console.Write(", ");
}





//Q7. Throw balls
Ball b1 = new Ball(new Color(11, 22, 33), 10);
Ball b2 = new Ball(new Color(11, 22, 33), 10);
Ball b3 = new Ball(new Color(11, 22, 33), 10);
Ball b4 = new Ball(new Color(11, 22, 33), 10);

b1.Throw();
b2.Throw();
b3.Throw();
b4.Throw();

b1.Throw();
b2.Throw();
b3.Throw();
b4.Throw();

Console.WriteLine($"b1 throw counts: {b1.GetThrowCount()}");
Console.WriteLine($"b2 throw counts: {b2.GetThrowCount()}");
Console.WriteLine($"b3 throw counts: {b3.GetThrowCount()}");
Console.WriteLine($"b4 throw counts: {b4.GetThrowCount()}");


b3.Pop();
b4.Pop();



b1.Throw();
b2.Throw();
b3.Throw();
b4.Throw();

Console.WriteLine("Post-pop:");
Console.WriteLine($"b1 throw counts: {b1.GetThrowCount()}");
Console.WriteLine($"b2 throw counts: {b2.GetThrowCount()}");
Console.WriteLine($"b3 throw counts: {b3.GetThrowCount()}");
Console.WriteLine($"b4 throw counts: {b4.GetThrowCount()}");

