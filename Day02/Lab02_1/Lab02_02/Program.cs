namespace Lab02_02
{
    internal class Program
    {
        /// <summary>
        /// Nhập vapo 1 ký tự, in ra ký tự là nguyên âm hay phụ âm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Mhap vao ky tu:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i': 
                    Console.WriteLine("{0} la nguyen am", ch);
                break;
                default: 
                    Console.WriteLine("{0} la phu am", ch);
                break;
            }

        }
    }
}
