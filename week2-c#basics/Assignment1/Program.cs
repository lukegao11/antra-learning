// See https://aka.ms/new-console-template for more information


using UnderstandingTypes;

Console.Write("Q1");
Console.Write("\n");
//1. Practice number sizes and ranges
Console.WriteLine("Size of sbyte: " + sizeof(sbyte) + " bytes");
Console.WriteLine("Minimum value of sbyte: " + sbyte.MinValue);
Console.WriteLine("Maximum value of sbyte: " + sbyte.MaxValue);

Console.WriteLine("Size of byte: " + sizeof(byte) + " bytes");
Console.WriteLine("Minimum value of byte: " + byte.MinValue);
Console.WriteLine("Maximum value of byte: " + byte.MaxValue);

Console.WriteLine("Size of byte: " + sizeof(ushort) + " bytes");
Console.WriteLine("Minimum value of byte: " + ushort.MinValue);
Console.WriteLine("Maximum value of byte: " + ushort.MaxValue);

Console.WriteLine("Size of byte: " + sizeof(int) + " bytes");
Console.WriteLine("Minimum value of byte: " + int.MinValue);
Console.WriteLine("Maximum value of byte: " + int.MaxValue);


Console.Write("\n");

Console.Write("Q2");

Console.Write("\n");

//2.Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
Console.Write("Enter number(integer) of centuries: ");
int centuries = int.Parse(Console.ReadLine());

long years = centuries * 100L;
long days = years * 365L + years / 4L - years / 100L + years / 400L;
long hours = days * 24L;
long minutes = hours * 60L;
long seconds = minutes * 60L;
long milliseconds = seconds * 1000L;
long microseconds = milliseconds * 1000L;
long nanoseconds = microseconds * 1000L;

Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
    centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);



Console.Write("\n");

Console.Write("Q3");

Console.Write("\n");
//3. Create a console application that can generate an integer between 1 and 3 then ask the user to guesss.
Guessnumber gn = new Guessnumber();
int target = gn.generatenumber();
Console.Write("Please guess what the number is: ");
int guessnum = int.Parse(Console.ReadLine());
gn.guessnumber(guessnum, target);







Console.ReadLine();