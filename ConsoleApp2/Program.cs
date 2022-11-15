using System;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //viét tiếng việt có dấu

            //in tên
            Console.WriteLine("nhập tên của bạn;");
            string Name = Console.ReadLine();
            Console.WriteLine(" tôi tên là  :" + "" + Name);

            //in số tuỏi
            Console.WriteLine("nhập số tuổi của bạn!");
            string Age = Console.ReadLine();
            Console.WriteLine("năm nay tôi  :" + "" + Age + "tuoi.");
            Console.ReadKey();
        }
    }
}