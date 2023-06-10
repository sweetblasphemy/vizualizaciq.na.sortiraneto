namespace vizualizaciq.na.sortiraneto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] values = input.Split(',');

            int[] array = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                array[i] = int.Parse(values[i].Trim());
            }

            Console.WriteLine("The array before sorting:");
            PrintArray(array);

            SelectionSortAlgorithm(array);

            Console.WriteLine("The array after sorting:");
            PrintArray(array);
        }

        static void SelectionSortAlgorithm(int[] array)
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

                if (minIndex != i)
                {
                    Console.WriteLine($"Element {array[i]} and {array[minIndex]} swapped positions.");
                    Swap(array, i, minIndex);
                }

                Console.WriteLine("The array after this step:");
                PrintArray(array);
            }
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();


        }
    }
}