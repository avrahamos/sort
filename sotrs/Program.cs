namespace sotrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 7, 8, 3, 1, 0, 86, 4 };
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", array));

            BubbleSort(array);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", array));

        }
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}
