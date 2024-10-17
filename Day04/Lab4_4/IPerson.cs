using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    //Định nghĩa giao diện
    internal interface IPerson
    {
        //Phương thức insert
        void Insert(object obj);
        //phương thức xóa
        void Delete(object obj);
        //phương thức sửa
        void Update(object obj);
        //phương thức hiển thị
        void Display(object obj);
    }
}
