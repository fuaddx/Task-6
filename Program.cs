namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { -1, -2, -3, -6, -7, -8 };
            Array(ref arr);
        }
        static void Array(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
                Console.WriteLine(arr[i]);
            }
        }

    }
}