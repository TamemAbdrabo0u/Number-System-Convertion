using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Number_System_Conersion.time;

namespace Number_System_Conersion
{
    class time
    {
        public static void wait(int sec)
        {
            Thread.Sleep(sec*1000);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             mystart:
            Console.WriteLine("Convert Decemal To .... (1) or ....... To Decemal (2)");
            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("Decemal To?   (Binary >> B  , Octal >> O , HexaDecemal >> H)");
                string l = Console.ReadLine();
                if (l == "B" || l == "b")
                {
                    Console.WriteLine("Enter The Decemal Number");
                    int Num = int.Parse(Console.ReadLine());
                    string Binary = Convert.ToString(Num, 2);
                    Console.WriteLine("Binary Converstion: " + Binary);
                }

                if (l == "O" || l == "o")
                {
                    Console.WriteLine("Enter The Decemal Number");
                    int Num = int.Parse(Console.ReadLine());
                    string Octal = Convert.ToString(Num, 8);
                    Console.WriteLine("Octal Convertion: " + Octal);
                }

                if (l == "H" || l == "h")
                {
                    Console.WriteLine("Enter The Decemal Number");
                    int Num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hexadecemal Convertion: {0:X}", Num);
                }

            }

            if (choose == 2)
            {
                Console.Write("Convert ..... To Decemal  ");
                Console.WriteLine("(Binary=> B , Octal=> O , HexaDecemal=> H)");
                string letter = Console.ReadLine();

                if (letter == "O" || letter == "o")
                {
                    Console.WriteLine("enter the octal number");
                    string num = Console.ReadLine();
                    var nO = Convert.ToInt32(num, 8);
                    Console.WriteLine("The Decemal Is: {0:d}", nO);
                }

                if (letter == "B" || letter == "b")
                {
                    Console.WriteLine("enter the Binary number");
                    string num2 = Console.ReadLine();
                    var nB = Convert.ToInt32(num2, 2);
                    Console.WriteLine("The Decemal Is: {0:d}", nB);
                }

                if (letter == "H" || letter == "h")
                {
                    Console.WriteLine("enter the hexadecemal number");
                    string num3 = Console.ReadLine();
                    var nH = Convert.ToInt32(num3, 16);
                    Console.WriteLine("The Decemal Is: {0:d}", nH);
                }
            }

            Console.WriteLine("\n");
            wait(2);
            Console.WriteLine("Try Again? (y/n)");
            string confirm = Console.ReadLine();
            if (confirm == "y")
            {
                Console.WriteLine("\n");
                goto mystart;
               
            }
        }
    }
}
