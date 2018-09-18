
// 4. Створити 2 паралельних масиви: назви та ціни  тoварів. Впорядкувати масиви по спаданню ціни(Sort()). 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_goods
{
    class Program
    {
        static void Print(string[] goods, int [] cost, string message = "")
        {
            Console.WriteLine(message);
            Console.WriteLine("goods\tcost\n- - - - - - -");
            for (int i = 0; i < goods.Length; ++i)
            {
                Console.WriteLine($"{goods[i]}\t{cost[i]}");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            string [] goods = { "sugar", "milk", "tea", "coffee", "water" };
            int[] cost = {10, 15, 25, 40, 5 };
            Print(goods, cost, "Before:");
            Array.Sort(cost, goods);
            Array.Reverse(cost);
            Array.Reverse(goods);
            Print(goods, cost, "After:");

        }
    }
}
