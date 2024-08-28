namespace CodingDemo.LearnArrays;

public class RearrangeSortedInMaxMin 
{
    public void MaxMin(int[] arr, int size)
    {
        //Create a result array to hold re-arranged version of given arr
        int[] result = new int[size];

        int pointerSmall = 0,     //PointerSmall => Start of arr
        pointerLarge = size - 1;   //PointerLarge => End of arr

        //Flag which will help in switching between two pointers
        bool switchPointer = true;

        for (int i = 0; i < size; i++)
        {
            if (switchPointer)
                result[i] = arr[pointerLarge--]; // copy large values
            else
                result[i] = arr[pointerSmall++]; // copy small values

            switchPointer = !switchPointer;   // switching between samll and large        
        }

        for (int j = 0; j < size; j++)
        {
            arr[j] = result[j];    // copying to original array
        }
    }

    //better approach with O(1) space
    public void MaxMin2(int[] arr, int size)
    {
        int maxIdx = size - 1;
        int minIdx = 0;
        int maxElem = arr[maxIdx] + 1; // store any element that is greater than the maximum element in the array 
        for (int i = 0; i < size; i++)
        {
            // at even indices we will store maximum elements
            if (i % 2 == 0)
            {
                arr[i] += (arr[maxIdx] % maxElem) * maxElem;
                maxIdx -= 1;
            }
            else
            { // at odd indices we will store minimum elements
                arr[i] += (arr[minIdx] % maxElem) * maxElem;
                minIdx += 1;
            }
        }
        // dividing with maxElem to get original values.
        for (int i = 0; i < size; i++)
        {
            arr[i] = arr[i] / maxElem;
        }
    }
}