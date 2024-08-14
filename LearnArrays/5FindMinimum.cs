namespace CodingDemo.LearnArrays;

public class FindMinimum 
{
    public int FindMinimumItem(int[] arr, int size)
    {
        int small = arr[0];
        int i = 0;

        while (i < size)
        {
            if (arr[i] < small)
                small = arr[i];
            i++;
        }

        return small;
    }
}