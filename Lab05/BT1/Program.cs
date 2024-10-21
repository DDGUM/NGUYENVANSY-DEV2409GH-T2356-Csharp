namespace BT1
{
    internal class Program
    {
        /// <summary>
        /// BT1(21/10/2024)
        /// --Khởi tạo một mảng một chiều số nguyên gồm 10 phần tử
        /// --tìm phần tử nhỏ nhất của mảng
        /// --đảo ngược mảng
        /// --sắp xếp mảng tăng hoặc giảm
        /// --tìm phần tử là số nguyên tố
        /// --In ra số lượng các số dương liên tiếp nhiều nhất
        /// --tính trung bình cộng các phần tử dương
        /// --kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen không?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Xuất unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Khai báo và khởi tạo mảng 1 chiều
            int[] arrays = { 11, 21, 31, 42, 24, 55, 33, 32, 67, 90, };

            int chon = 0;

            do
            {
                menu();
                Console.Write("Mời bạn chọn:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1: tìm phần tử nhỏ nhất của mảng");
                        int min = minArrays(arrays);
                        Console.WriteLine("Min: {0}", min);
                        break;
                    case 2:
                        Console.WriteLine("2: đảo ngược mảng");
                        //Console.WriteLine("Array:{0} ", String.Join(" ", arrays));
                        //Array.Reverse(arrays);
                        //Console.WriteLine("Reverse: " + String.Join(" ", arrays));
                        ReverseArray(arrays);
                        break;
                    case 3:
                        Console.WriteLine("3: sắp xếp mảng tăng hoặc giảm");
                        SortArray(arrays);
                        break;
                    case 4:
                        Console.WriteLine("4: tìm phần tử là số nguyên tố");
                        PrintPrime(arrays);
                        break;
                    case 5:
                        Console.WriteLine("5: In ra số lượng các số dương liên tiếp nhiều nhất");
                        break;
                    case 6:
                        Console.WriteLine("6: tính trung bình cộng các phần tử dương");
                        break;
                    case 7:
                        Console.WriteLine("7: kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen không?");
                        break;
                    case 8:
                        Console.WriteLine("8: Kết thúc");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng");
                        break;
    {
                        }
                }
                while (chon != 0) ;
                ////duyệt mảng và in ra dữ liệu
                //Console.Write("Các phần tử trong mảng: ");
                //for (int i = 0; i < m.Length; i++)
                //{
                //    Console.Write(" {0} ", m[i]);
                //}
                //Console.WriteLine();

                ////tìm phần tử nhỏ nhất
                //int min = m[0];
                //for (int i = 0; i < m.Length; i++)
                //{
                //    if (m[i] < min)
                //        min = m[i];
                //}
                //Console.WriteLine("Phần tử nhỏ nhất là: " + min);
            }

        static void menu()
            {
                Console.WriteLine("==========Menu==========");
                Console.WriteLine("1: tìm phần tử nhỏ nhất của mảng.\r\n" +
                    "2: đảo ngược mảng.\r\n" +
                    "3: sắp xếp mảng tăng hoặc giảm.\r\n" +
                    "4: tìm phần tử là số nguyên tố.\r\n" +
                    "5: In ra số lượng các số dương liên tiếp nhiều nhất.\r\n" +
                    "6: tính trung bình cộng các phần tử dương.\r\n" +
                    "7: kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen không?\r\n" +
                    "8: Kết thúc.\r\n");
            }

            /// <summary>
            /// 1: tìm phần tử nhỏ nhất của mảng
            /// </summary>
            /// <param name="array"></param>
            /// <returns></returns>
            static int minArrays(int[] array)
            {
                int min = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                        array[i] = min;
                }
                return min;
            }

            /// <summary>
            /// 2: đảo ngược mảng
            /// </summary>
            /// <param name="arr"></param>
            static void ReverseArray(int[] arr)
            {
                Console.WriteLine("Array:{0} ", String.Join(" ", arr));
                Array.Reverse(arr);
                Console.WriteLine("Reverse: " + String.Join(" ", arr));
            }

            /// <summary>
            /// 3: sắp xếp mảng tăng hoặc giảm
            /// </summary>
            /// <param name="arr"></param>
            static void SortArray(int[] arr)
            {
                Console.WriteLine("Mảng trước khi sắp:{0} ", String.Join(" ", arr));
                Array.Sort(arr);
                Console.WriteLine("Sorted: " + String.Join(" ", arr));
            }

            /// <summary>
            /// 4: tìm phần tử là số nguyên tố
            /// </summary>
            /// <param name="arr"></param>
            static void PrintPrime(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (IsPrime(arr[i]))
                    {
                        Console.Write(" {0} ", arr[i]);
                    }
                }
                Console.WriteLine();
            }
            /// <summary>
            /// IsPrime
            /// </summary>
            /// <param name="number"></param>
            /// <returns></returns>
            static bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static int maxcountpositivenumber(int[] arr) {
            int maxcount = 0;
            int currencount = 0;

        }
    }