namespace CodingDemo.Sort;

public class SelectionSort
{
    //O(n2) time complexity
    public void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            Swap(arr, i, minIndex);
        }
    }
    
    private void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }
}