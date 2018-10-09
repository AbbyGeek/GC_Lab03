using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name, buddy?");
            string name = Console.ReadLine();
            bool go = true;
            

            while (go == true)
            {
                try
                {
                    Console.WriteLine("Enter a number between 1 and 100");
                    string x = Console.ReadLine();

                    int num = int.Parse(x);

                    if (num > 100)
                    {
                        Console.WriteLine(name + ", follow the rules");
                        continue;
                    }


                    if (num % 2 != 0) { Console.WriteLine(num + ": odd"); }
                    else if (num <= 25) { Console.WriteLine("Even and less than 25"); }
                    else if (num <= 60) { Console.WriteLine("even"); }
                    else if (num < 100) { Console.WriteLine(num + ": even"); }
                    else { Console.WriteLine("Odd"); }

                    Console.WriteLine(name + ", would you like to quit? (y/n)");
                    go = Console.ReadLine() == "y" ? false : true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(name + ", follow the rules");
                    continue;
                }   
            }


            
                
                
            
        }
    }
}

