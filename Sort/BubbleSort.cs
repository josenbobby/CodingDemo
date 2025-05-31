namespace CodingDemo.Sort;

/*
Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order. 
This algorithm is not suitable for large data sets as its average and worst-case time complexity are quite high.

We sort the array using multiple passes. After the first pass, the maximum element goes to end (its correct position). 
Same way, after second pass, the second largest element goes to second last position and so on.
In every pass, we process only those elements that have already not moved to correct position. 
After k passes, the largest k elements must have been moved to the last k positions.
In a pass, we consider remaining elements and compare all adjacent and swap if larger element is 
before a smaller element. If we keep doing this, we get the largest (among the remaining elements) at its correct position.

Complexity Analysis of Bubble Sort:
Time Complexity: O(n2)
Auxiliary Space: O(1)

Advantages of Bubble Sort:
Bubble sort is easy to understand and implement.
It does not require any additional memory space.
It is a stable sorting algorithm, meaning that elements with the same key value maintain their relative order in the sorted output.
Disadvantages of Bubble Sort:
Bubble sort has a time complexity of O(n2) which makes it very slow for large data sets.
Bubble sort has almost no or limited real world applications. It is mostly used in academics to teach different ways of sorting.
 */
public class BubbleSort
{
    public void Sort(int[] arr, int n)
    {
        int i, j, temp;
        var swapped = false;
        for (i = 0; i < n; i++)
        {
            swapped = false;
            for (j = 0; j < n; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                    swapped = true;
                }
            }

            if (swapped == false)
            {
                break;
            }
        }
    }

    // An optimized version of Bubble Sort From GFG
    static void BubbleSortGFG(int[] arr, int n)
    {
        int i, j, temp;
        bool swapped;
        for (i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {

                    // Swap arr[j] and arr[j+1]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were
            // swapped by inner loop, then break
            if (swapped == false)
                break;
        }
    }

    private void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    } 
}