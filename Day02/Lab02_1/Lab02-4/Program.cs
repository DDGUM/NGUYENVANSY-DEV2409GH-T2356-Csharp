namespace Lab02_4
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các số nguyên tố từ 2-100
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo biến đánh dấu
            bool check_1;
            //duyệt từ 2-100
            for (int i = 2; i <= 100; i++)
            { 
            check_1 = true; //giả sử i là số nguyên tố
            for (int j = 2; j <= i / 2; j++) //duyệt từ 2-j/2
                {
                    if (i % j == 0)  //nếu i chia hết cho j thì
                    {
                        check_1 = false; //kết luận  không có số nguyên tố
                        break; //thoát khỏi vòng lặp
                    }    
                }
                if (check_1) //nếu giả sử vẫn đúng -> i là số nguyên tố
                    Console.Write("{0}", i);
            }
        }
    }
}
