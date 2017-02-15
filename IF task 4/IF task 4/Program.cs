using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna 3 Numeroa: ");
            int[] arr = new int[3];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr[0]);
        }
    }
}
