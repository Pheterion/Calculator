using System;
using System.Dynamic;

namespace ConsoleCalculator
{
  
    class Program
    {
       
        static void Main()
        {
            Console.WriteLine("Hello World!");
            NumberClass FirstNumber = new NumberClass();
            NumberClass SecondNumber= new NumberClass();
            FirstNumber.Num = Numsetter();
            SecondNumber.Num = Numsetter();
            string mode;
          Console.WriteLine("For + write a\nFor - write s\nFor * write m\nFor / write d\nIf you want to change the first number write num1 and for the second one num2");
            for (bool flag=true; flag == true ; ) {
                mode = Console.ReadLine();  
                switch (mode)
                {
                    case "a":
                        Console.WriteLine(FirstNumber.Num=(FirstNumber.Num + SecondNumber.Num));
                        break;
                    case "s":
                        Console.WriteLine(FirstNumber.Num = (FirstNumber.Num - SecondNumber.Num));
                        break;
                    case "m":
                        Console.WriteLine(FirstNumber.Num = (FirstNumber.Num * SecondNumber.Num));
                        break;
                    case "d":
                        if (SecondNumber.Num == 0) {
                            Console.WriteLine("You cant devide by zero so please change it or you wont be able to divide");
                                break;
                        }
                        Console.WriteLine(FirstNumber.Num = (FirstNumber.Num / SecondNumber.Num));
                        break;
                    case "num1":
                        FirstNumber.Num = Numsetter();
                        break;
                    case "num2":
                        SecondNumber.Num = Numsetter();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
       public static double Numsetter()
        {
            Console.WriteLine("Please enter your number");
            double number = double.Parse(Console.ReadLine());
            return number;
        }
    }
}
