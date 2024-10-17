namespace Lab4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo một nhân viên
            IPerson staff = new Staff();
            object data = "Bach khoa Aptech";
            //gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            //tạo sinh viên
            IPerson student = new Student() { Id = "S10", Name = "Tai", Age = 22 };
            //hiển thị dữ liệu
            student.Display(student);
        }
    }
}
