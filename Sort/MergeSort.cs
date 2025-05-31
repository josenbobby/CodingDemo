namespace CodingDemo.Sort;

/*
 *Merge sort is a popular sorting algorithm known for its efficiency and stability.
 * It follows the divide-and-conquer approach to sort a given array of elements.

Here’s a step-by-step explanation of how merge sort works:

Divide: Divide the list or array recursively into two halves until it can no more be divided.
Conquer: Each subarray is sorted individually using the merge sort algorithm.
Merge: The sorted subarrays are merged back together in sorted order. 
The process continues until all elements from both subarrays have been merged.

Complexity Analysis of Merge Sort:
Time Complexity:
Best Case: O(n log n), When the array is already sorted or nearly sorted.
Average Case: O(n log n), When the array is randomly ordered.
Worst Case: O(n log n), When the array is sorted in reverse order.
Auxiliary Space: O(n), Additional space is required for the temporary array used during merging.

Applications of Merge Sort:
Sorting large datasets
External sorting (when the dataset is too large to fit in memory)
Inversion counting
Merge Sort and its variations are used in library methods of programming languages. 
For example its variation TimSort is used in Python, Java Android and Swift. 

The main reason why it is preferred to sort non-primitive types is stability which is not there in QuickSort. 
For example Arrays.sort in Java uses QuickSort while Collections.sort uses MergeSort.

It is a preferred algorithm for sorting Linked lists.
It can be easily parallelized as we can independently sort subarrays and then merge.
The merge function of merge sort to efficiently solve the problems like union and intersection of two sorted arrays.

Advantages of Merge Sort:
Stability : Merge sort is a stable sorting algorithm, which means it maintains the relative order of equal elements in the input array.
Guaranteed worst-case performance: Merge sort has a worst-case time complexity of O(N logN) , which means it performs well even on large datasets.
Simple to implement: The divide-and-conquer approach is straightforward.
Naturally Parallel : We independently merge subarrays that makes it suitable for parallel processing.

Disadvantages of Merge Sort:
Space complexity: Merge sort requires additional memory to store the merged sub-arrays during the sorting process.
Not in-place: Merge sort is not an in-place sorting algorithm, which means it requires additional memory to store the sorted data. 
This can be a disadvantage in applications where memory usage is a concern.
Slower than QuickSort in general. QuickSort is more cache friendly because it works in-place.

source: https://www.geeksforgeeks.org/merge-sort/
 */

public class MergeSort
{
    public void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;
            
            Sort(arr, left, middle);
            Sort(arr, middle + 1, right);
            
            Merge(arr, left, middle, right);
        }
    }
    public void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftList = new int[n1];
        int[] rightList = new int[n2];

        int i, j;

        for (i = 0; i < n1; i++)
        {
            leftList[i] = arr[left + i];
        }

        for (j = 0; j < n2; j++)
        {
            rightList[j] = arr[middle + 1 + j];
        }
        
        // Merge the temp arrays

        // Initial indexes of first
        // and second subarrays
        i = 0;
        j = 0;

        int k = left;
        while (i < n1 && j < n2)
        {
            if (leftList[i] <= rightList[j])
            {
                arr[k] = leftList[i];
                i++;
            }
            else
            {
                arr[k] = rightList[j];
                j++;
            }

            k++;
        }
        
        //Copy remaining elements of left
        while (i < n1)
        {
            arr[k] = leftList[i];
            i++;
            k++;
        }
        
        while (j < n2)
        {
            arr[k] = rightList[j];
            j++;
            k++;
        }
        
    }
}