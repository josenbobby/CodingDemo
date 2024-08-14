namespace CodingDemo.LearnArrays;

public class RearrangePositiveAndNegative 
{
    //O(n) with single pass and in place arrayß
    public void ReArrange2(int[] arr, int size)
    { 
        int j = 0; 
        for (int i = 0; i < size; i++) { 
            if (arr[i] < 0) {   // if negative number found
                if (i != j) 
                    Swap(arr, i, j);  // swapping with leftmost positive 
                j++; 
            } 
        } 
    }
    
    
    private void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
        // int temp = arr[i];
        // arr[i] = arr[j];
        // arr[j] = temp;
    }
    
    //O(n) but 3 passes
    public void ReArrange(int[] arr, int size)
    {
        int[] newArray = new int[size];
        int newArrayIndex = 0;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] < 0)
            {
                newArray[newArrayIndex] = arr[i];
                newArrayIndex++;
            }
        }
        
        for (int i = 0; i < size; i++)
        {
            if (arr[i] >= 0)
            {
                newArray[newArrayIndex] = arr[i];
                newArrayIndex++;
            }
        }

        for (int j = 0; j < newArrayIndex; j++)
        {
            arr[j] = newArray[j];
        }
    }
    
    
}