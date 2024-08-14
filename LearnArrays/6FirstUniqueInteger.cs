namespace CodingDemo.LearnArrays;

public class FirstUniqueInteger {

    public int FirstUnique(int[] arr, int size)
    {
        bool isRepeated = false;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (arr[i] == arr[j] && i != j)
                {
                    isRepeated = true;
                }
            }

            if (isRepeated == false)
            {
                return arr[i];
            }

            isRepeated = false;
        }

        return -1;
    }
    
}