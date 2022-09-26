using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository
{
        class Program
        {
                static void Main(string[] args)
                {
                        string welcomeString = "Please write number (int): ";
                        int a=0;
                        int b=0;
                        int c=0;
                        Console.Write(welcomeString);
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write(welcomeString);
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("a + b = " + c.ToString());
                        Console.ReadKey();
                }
        }
}
