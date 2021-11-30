using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Design design1 = new Design { k = 5, b = 30};
            Design design2 = new Design { k = -4, b = 80 };
            design1.Root();
            design2.Root();
            Console.ReadKey();
        }

        struct Design
        {
            public int k;
            public int b;

            public void Root()
            {
                double х = (((double)0) - b) / k;
                Console.WriteLine("Ответ: {0:F2}", х);
            }
        
        }
        
    }
}
