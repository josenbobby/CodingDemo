namespace CodingDemo.Sort;

//Best case- O(nlogn), Average case - is nlogn which makes it one of the best sorting algos
//Worst case O(n2) - pivot in each step results in consistently unblalanced partitions
//Auxiliary space - without recursive stack space its O(1) , but with recursive stack its O(n)

/*
Advantages of Quick Sort:
    It is a divide-and-conquer algorithm that makes it easier to solve problems.
    It is efficient on large data sets.
    It has a low overhead, as it only requires a small amount of memory to function.
    It is Cache Friendly as we work on the same array to sort and do not copy data to any auxiliary array.
    Fastest general purpose algorithm for large data when stability is not required.
    It is tail recursive and hence all the tail call optimization can be done.
Disadvantages of Quick Sort:
    It has a worst-case time complexity of O(N 2 ), which occurs when the pivot is chosen poorly.
    It is not a good choice for small data sets.
    It is not a stable sort, meaning that if two elements have the same key, 
    their relative order will not be preserved in the sorted output in case of quick sort, 
    because here we are swapping elements according to the pivot’s position (without considering their original positions).

Lomuto’s Partition Scheme:

This algorithm works by assuming the pivot element as the last element. 
If any other element is given as a pivot element then swap it first with the last element. 
Now initialize two variables i as low and j also low,  
iterate over the array and increment i when arr[j] <= pivot and swap arr[i] with arr[j] otherwise increment only j. 
After coming out from the loop swap arr[i+1] with arr[hi]. This i stores the pivot element.

source: https://www.geeksforgeeks.org/quick-sort-algorithm/

*/
public class QuickSort
{
    public void Sort(int[] arr, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            int pivot = Partition(arr, leftIndex, rightIndex);
            Sort(arr, leftIndex, pivot - 1);
            Sort(arr, pivot + 1, rightIndex);
        }
    }

    private int Partition(int[] arr, int leftIndex, int rightIndex)
    {
        int pivot = arr[rightIndex];
        int i = leftIndex - 1;
        
        for (int j = leftIndex; j <= rightIndex - 1 ; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i+1, rightIndex);

        return i+1;
    }

    private void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
        // int temp = arr[i];
        // arr[i] = arr[j];
        // arr[j] = temp;
    }
    
    public int PartitionHoare(int[] arr, int low, int high)
    {
        int pivot = arr[low];
        int i = low - 1, j = high + 1;

        while (true) {
            // Find leftmost element greater
            // than or equal to pivot
            do {
                i++;
            } while (arr[i] < pivot);

            // Find rightmost element smaller
            // than or equal to pivot
            do {
                j--;
            } while (arr[j] > pivot);

            // If two pointers met.
            if (i >= j)
                return j;
            
            Swap(arr,arr[i], arr[j]);
        }
    }
    public void SortHoare(int[] arr, int low, int high)
    {
        if (low < high) {
            /* pi is partitioning index,
            arr[p] is now at right place */
            int pi = PartitionHoare(arr, low, high);

            // Separately sort elements before
            // partition and after partition
            SortHoare(arr, low, pi);
            SortHoare(arr, pi + 1, high);
        }
    }
}