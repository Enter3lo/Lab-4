using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Допустимые операции:  +, -, *, /, 8CC");
            Console.Write("Первый операнд:  "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Операция:  "); string action = Console.ReadLine();
            char op = action[0];
            double b;
            int i;
            switch(op)
            {
                case '+': Console.Write("Второй операнд:  "); b = Convert.ToDouble(Console.ReadLine()); 
                             Console.WriteLine("Результат:  " + (a + b));
                                break;
                case '-': Console.Write("Второй операнд:  "); b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Результат:  " + (a - b));
                             break;
                case '*': Console.Write("Второй операнд:  "); b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Результат:  " + (a * b));
                                break;
                case '/': Console.Write("Второй операнд:  "); b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Результат:  " + (a / b));
                                break;
                case '8': string result = string.Empty;
                          while(a > 0)
                          {
                                i = a % 8;
                                result = i + result;
                                a /= 8;
                          }
                          Console.WriteLine("Результат:  "+result);
                          break;
            }
            Console.ReadKey();
        }
    }
}
