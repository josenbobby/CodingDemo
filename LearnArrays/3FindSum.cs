using CodingDemo.Sort;

namespace CodingDemo.LearnArrays;

public class FindSum
{
    public int[] FindSumArray(int[] arr, int value)
    {
        int size = arr.Length;
        int pointer1 = 0;
        int pointer2 = size - 1;

        //Need to sort the incoming array for the logic to work
        //Array.Sort(arr);
        QuickSort qs = new QuickSort();
        qs.Sort(arr, 0, size - 1);

        while (pointer1 != pointer2)
        {
            int sum = arr[pointer1] + arr[pointer2];
            if (sum == value)
            {
                return new int[] { arr[pointer1], arr[pointer2] };
            }
            else if (sum < value)
            {
                pointer1++;
            }
            else
            {
                pointer2--;
            }
        }
        return new int[] {};
    }
}