using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    /// <summary>
    /// Định nghĩa lớp trừu tượng
    /// </summary>
    internal abstract class Shape
    {
        protected float radius, lenght, width;
        // khai báo cáo phương thức trừu tượng
        public abstract float Area(); //tính diện tích
        public abstract float Circumferemce();//tính chu vi
    }
}
