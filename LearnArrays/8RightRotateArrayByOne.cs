namespace CodingDemo.LearnArrays;

public class RightRotateArrayByOne {
    public void RightRotate(int[] arr, int size)
    {
        //Store the last element of the array.
        //Start from the last index and right shift the array by one.
        //Make the last element stored to be the first element of the array.
        int lastElement = arr[size - 1];

        for (int i = size - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[0] = lastElement;
    }
}