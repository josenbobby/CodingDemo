using CodingDemo.Sort;

namespace CodingDemo.LearnArrays;

public class SecondMaximum {

    public int SecondMaxInArray(int[] arr, int size)
    {
        QuickSort qs = new QuickSort();
        qs.Sort(arr, 0 , arr.Length);
        for (int i = size; i >= 0; i--)
        {
            int first = arr[size];
            if (arr[i] != first)
            {
                return arr[i];
            }
        }
        
        return -1;
    }
    
    //Find Second Maximum Value in an Array
    static int findSecondMaximum(int []arr, int size)
    {

        int max = Int32.MinValue;
        int secondmax = Int32.MinValue;

        // Keep track of the maximum value, whenever the value at an array index is greater
        // than the current maximum value, then make that max value second max value and
        // make that index value maximum value 
        for (int i = 0; i < size; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }//end of for-loop

        for (int i = 0; i < size; i++)
        {
            if (arr[i] > secondmax && arr[i] < max)
                secondmax = arr[i];
        }//end of for-loop

        return secondmax;
    }
    
    //ß Finding and printing the 2nd max element in this method
    public static void find_second_max(int[] arr, int arr_size)
    {
        int i, max, secondmax;
 
        // Minimum two elements must be in an array 
        if (arr_size < 2) {
            Console.WriteLine(" The given Input is Invalid!");
            return;
        }
 
        max = secondmax = int.MinValue;
        for (i = 0; i < arr_size; i++) {
            // If ith element is greater than max
            // Then update both max and secondmax
            if (arr[i] > max) {
                secondmax = max;
                max = arr[i];
            }
            // If the ith element is in between max and secondmax
            // Then update secondmax
            else if (arr[i] > secondmax && arr[i] != max)
                secondmax = arr[i];
        }

 
        if (secondmax == int.MinValue)
            Console.Write("There is no 2nd maximum element\n");
        else
            Console.Write("The 2nd maximum element is " + secondmax);
    }
    
}