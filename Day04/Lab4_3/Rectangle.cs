using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Rectangle : Shape
    {
            //phương thức nhập liệu
            public void InputData()
        {
            Console.Write("Nhap chieu dai:");
            lenght = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong:");
            width = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return lenght * width;
        }
        // ghi đè phương thức tính chu vi
        public override float Circumferemce()
        {
            return 2 * lenght * width;
        }
    }
}
