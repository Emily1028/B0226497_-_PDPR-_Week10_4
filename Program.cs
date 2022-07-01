using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR _Week10_4");
            string ans = "yes";
            while (ans == "yes")
            {
                Console.Write("請輸入網路購物重量:");
                string kgStr = Console.ReadLine();
                int kg = int.Parse(kgStr);
                
                if (kg >= 1 && kg<= 5)
                {
                    
                    Console.WriteLine("網路購物重量:{0}，運費:{1}", kg, 299 + kg * 30);
                }
                else if (kg > 5)
                {
                    
                    Console.WriteLine("網路購物重量:{0}，運費:{1}", kg, 299 + kg * 20);
                }
                Console.Write("請輸入\"yes\"繼續計算，其它任意鍵離開:");
                ans = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
