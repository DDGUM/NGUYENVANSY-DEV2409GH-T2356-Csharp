using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    internal class Document : IStoreable, IEncryptable
    {
        public string content { get; set; }
        public string Data
        {
            get { return content; }
            set { content = Value; }
        }
        public void Write(string fileName)
        {
            using (fileName fs = new FileStream(fileName, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(content);
                Console.WriteLine($"Nội dung viết{fileName}");

            }
        }
        public void Read(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File{fileName} không thoát");
                return;
            }
            using (fileName fs = new fileName(fileName, FileMode.Open))
                using
}
    }
