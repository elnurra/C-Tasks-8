using System;
using TaskForAbstractClass.Models;

namespace TaskForAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int input;
            do
            {


                Console.WriteLine("Hello, and welcome to the Los Pollos Hermanos family! My name is Gustavo, but you can call me Gus.");
                Console.WriteLine("Choose what you will calculate: \n 1. Square \n 2. Rectangular \n 0. Exit ");
                int button = int.Parse(Console.ReadLine());

                switch (button)
                {
                    case 1:
                        Console.WriteLine("input the value of side square");
                        double side = double.Parse(Console.ReadLine());
                        Square square = new Square(side);
                        square.CalcArea();
                        break;
                    case 2:
                        Console.WriteLine("Input the value width of side rectangular");
                        double width = double.Parse(Console.ReadLine());
                        double length = double.Parse(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(width, length);
                        rectangular.CalcArea();
                        break;
                    
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
                Console.WriteLine("Do u want continue?: Any key - Yes 0. Exit");
                input = int.Parse(Console.ReadLine());
            } while (input != 0);
        }
    }
}
