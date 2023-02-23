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
ManageItem mi = new ManageItem();
mi.Run();




//