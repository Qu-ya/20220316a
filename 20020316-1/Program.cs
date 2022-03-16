using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20020316_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("請輸入你的分數:");
            score = Convert.ToInt32(Console.ReadLine());
            /*if (score >= 60)
            {
                Console.WriteLine("同學，你這次及格");
            }else
            {
                Console.WriteLine("同學，你這次不及格");
            }*/
            string result = score >= 60 ? "及格" : "不及格";
            Console.WriteLine("同學，這次你{0}", result);
            Console.ReadLine();
        }
    }
}
