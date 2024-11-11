using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string tectBigNumber = "1000000000000000000";
            long bigNumber = Convert.ToInt64(tectBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-40.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5.0000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
            Console.ReadLine();
        }
    }
}
