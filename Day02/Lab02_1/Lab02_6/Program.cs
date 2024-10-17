namespace Lab02_6
{
    internal class Program
    {
        /// <summary>
        /// Sử dung foreach in ra danh sách các phân tử của mảng 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo và khởi tại mảng tên
            string[] names = { "Thang", "Long", "Hoa", "Dao" };
            foreach (var n in names) 
            {
                Console.WriteLine(n);
            }
        }
    }
}
