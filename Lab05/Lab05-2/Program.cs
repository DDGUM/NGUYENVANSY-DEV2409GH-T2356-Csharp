namespace Lab05_2
{
    internal class Program
    {
        static void Main(string[] args)
        {nameof 
            Console.WriteLine("mang 2 chieu: ");
            int[,] arrays =
            {
                { 4, 6 , 9 },
                { 2, 4 , 5 },
                { 9, 2 , 6 },
                { 1, 6 , 3 },
            };
            // DUYET MANG va IN
            printarray(arrays);
        }

        static void printarray(int[,] arrays)
        {
            Console.WriteLine("cac  thanh phan trong mang\n");
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arrays.GetUpperBound(1); j++)
                {
                    Console.Write(" {0} ", arrays[i, j]);

                }
                Console.WriteLine();

            }
        }
        static void printarrayXY(int[,] arrays)
        {
            Console.WriteLine("cac phan tu chi co hang bang chi so cot :");
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arrays.GetUpperBound(1); j++)
                {
                    if( i == j )
                    Console.Write(" {0} ", arrays[i, j]);

                }
                Console.WriteLine();

            }
        }


    }
}

