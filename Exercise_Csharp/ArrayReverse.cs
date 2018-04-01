using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Csharp
{
    class ArrayReverse
    {
        public static void Run()
        {
            
            string[] arr = new string[5];
            Console.WriteLine("Nhập vào một mảng kiểu chuỗi gồm ");
            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write("Nhập giá trị thứ {0} arr[{1}] = ", i + 1, i);
                arr[i]=Console.ReadLine();
            }
            Console.Write("Hiển thị chuỗi đảo ngược là: ");
            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadKey();
        }
         
    }
}
