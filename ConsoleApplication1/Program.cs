using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var w=new StreamWriter("D:\\log.txt", true, Encoding.UTF8))
            {
                w.WriteLine(DateTime.Now);
            }
            Console.WriteLine("Write Successfully");
            Console.Read();
        }
    }
}
