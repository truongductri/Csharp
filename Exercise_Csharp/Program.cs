using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chon chuong trinh chay:");
            var opt = Console.ReadLine();
            while (opt != "0")
            {
                switch (opt)
                {
                    case "1":
                        Console.WriteLine("ArrayPrint program is running...");
                        ArrayPrint.Run();
                        break;
                    case "2":
                        ArrayReverse.Run();
                        break;
                    default:
                        Console.WriteLine("No action!");
                        break;
                }
                Console.WriteLine("Chon chuong trinh chay:");
                opt = Console.ReadLine();
            }
            Console.WriteLine("Exit!");
            Console.ReadKey();

        }
    }
}
