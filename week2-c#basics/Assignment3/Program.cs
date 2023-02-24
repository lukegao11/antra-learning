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
for (int i = 1; i < 11; i++) {
    Console.Write(Fibonacci.nthFibonacci(i));
    Console.Write(", ");
}














