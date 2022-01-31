using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    internal class UC2_WinOrLoss
    {
        public static void winOrloss()
        {
            double totalMoney = 100.00;
            double betMoney = 1.00;
            Random random = new Random();
            int Check = random.Next(0, 2);
            if (Check == 1)
            {
                Console.WriteLine("win");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("win" );
                Console.ReadKey();
            }
        }
    }
}
