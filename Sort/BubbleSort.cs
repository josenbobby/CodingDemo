namespace CodingDemo.Sort;

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
    
    private void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    } 
}