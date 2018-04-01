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
            int[] arr = new int[10];
            Console.WriteLine("Nhập vào một mảng số nguyên nhỏ hơn hoặc bằng 10 phần tử");
            for (int i=0; i < arr.Length; i++)
            {
                Console.Write("Nhập phần tử {1} a[{0}] =", i,i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mảng gồm 10 phần tử là:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            
            Console.ReadKey();
            
        }
    }
}
