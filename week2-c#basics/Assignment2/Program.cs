//1. Copying an Array
using HW5;

int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
int[] arr1 = new int[10];
for (int i = 0; i < arr.Length; i++) {
    arr1[i] = arr[i];
}
Console.WriteLine("print the original array:");    
foreach (int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine("\nprint the second array:");
foreach (int i in arr)
{
    Console.WriteLine(i);
}



//2.manage a list of elements.
manageitem mi = new manageitem();
mi.run();


//3. find prime in range
Console.WriteLine("please input the start number of the range where you want to find prime numbers");
int startNum = int.Parse(Console.ReadLine());
Console.WriteLine("please input the end number of the range where you want to find prime numbers");
int endNum = int.Parse(Console.ReadLine());
GetPrimeNum GetPrimeNum= new GetPrimeNum();
int[] primeArr = GetPrimeNum.FindPrimesInRange(startNum, endNum);

Console.WriteLine("\nthe prime numbers are:");
foreach (int i in primeArr)
{
   Console.WriteLine(i);
}






//4. rotate and sum
RotateSumArray RotateSumArray= new RotateSumArray();
RotateSumArray.RotateSum();





//5. find the longest sequence
Console.Write("Enter an integer array, seperat by space: ");
int[] arrayfor5 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
FindLongestSequence.FindLongest(arrayfor5);


//7. find the frequent number
Console.Write("Enter an integer array, seperat by space: ");
int[] arrayfor7 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int res7 = FindFrequentNum.FindMostFrequentNumber(arrayfor7);
Console.WriteLine("the most frequent number is {0}", res7);



