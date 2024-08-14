namespace CodingDemo.LearnArrays;

public class FindProduct
{
    public int[] FindProductArray (int[] arr, int size)
    {
        int n = size;
        int temp = 1;
        int i;
        int[] product = new int[size];
        // temp contains product of elements on left side excluding arr[i]

        for (i = 0; i < n; i++)
        {
            product[i] = temp;
            temp *= arr[i];
        }

        temp = 1;
        // temp contains product of elements on right side excluding arr[i]
        for (i = n - 1; i >= 0; i--)
        {
            product[i] *= temp;
            temp *= arr[i];
        }

        return product;
    }
}