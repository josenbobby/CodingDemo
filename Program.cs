// See https://aka.ms/new-console-template for more information

using CodingDemo.LearnArrays;
using CodingDemo.LinkedList;
using CodingDemo.Sort;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

//int[] arr = {1, 21, 3, 14, 5, 60, 7, 6};
//int[] arr = { 12, -8, -26, 17, -25, -1, -33, 6 };
//int[] arr = { 2,-4,6,7,-8,9,16,6 };

// int[] arr = { 2, 4, 3, 5 };

// QuickSort qs = new QuickSort();
// qs.Sort(arr, 0, arr.Length - 1);

// FindSum fs = new FindSum();
// var sum = fs.FindSumArray(arr, 16);
// foreach (var item in sum)
// {
//     Console.WriteLine(item);    
// }

// CheckPalindrome p = new CheckPalindrome();
// var isPalindrome = p.Check("malayalam");
//
// Console.WriteLine(isPalindrome);

// FindProduct fp = new FindProduct();
// var product = fp.FindProductArray(arr, arr.Length);
// foreach (var item in product)
// {
//     Console.WriteLine(item);    
// }

// int[] arr = { 2, 4, 3, 5, 4 , 2};
// FirstUniqueInteger fu = new FirstUniqueInteger();
// var number = fu.FirstUnique(arr, arr.Length);

// int[] arr = { 23, 1, 10, 5, 2 };
// InsertionSort sort  = new InsertionSort();
// sort.Sort(arr);



//int[] arr = { 10, 80, 30, 90, 40 };

//QuickSort qs = new QuickSort();
//qs.Sort(arr, 0, arr.Length - 1);

//foreach (var item in arr)
//{
//    Console.WriteLine(item);    
//}

LinkedListImplementation list = new LinkedListImplementation(); // Linked List created
for (int i = 1; i < 10; i++)
{
    list.InsertAtHead(i); // inserting data at head of the list
    list.PrintList();
}






