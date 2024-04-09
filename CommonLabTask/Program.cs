using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLabTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 15, 92, 35, 4, 51, 6, 27, 8, 101,};
            int max1 = number[0];
            int max2 = number[0];
            int min1 = number[0];
            int min2 = number[0];
            int sum1 = max1 + max1;
            int sum2 = min2 + min1;
            foreach (int i in number)
            {
                if(i> max1)
                {
                    max1 = max2;
                    max1 = i;
                }
                else if(i > max2 && i != max1){
                    max2 = i;
                }
                if(i < min1)
                {
                    min1 = min2;
                    min1 = i;
                }
                else if(i<min2 && i != min1)
                {
                    min2 = i;
                }
            }
            Console.WriteLine("Hansı əməliyyatı yerinə yetirmək istəyirsiniz ?");
            string operations = Console.ReadLine();
            switch (operations)
            {
                case "+":
                    Console.WriteLine(sum1 + sum1);
                    break;
                case "-":
                    Console.WriteLine(sum1 - sum1);
                    break;
                case "*":
                    Console.WriteLine(sum1 * sum1);
                    break;
                case "/":
                    Console.WriteLine(sum1 / sum1);
                    break;
            }
        }

    }
}
