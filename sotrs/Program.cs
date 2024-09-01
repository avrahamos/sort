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

            Console.WriteLine("Sorted bubble array:");
            Console.WriteLine(string.Join(", ", array));

            SelectionSort(array);
            Console.WriteLine("Sorted selection array:");
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
        static void SelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
