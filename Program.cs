using System;
using System.Dynamic;

namespace ConsoleCalculator
{
  
    class Program
    {
       
        static void Main()
        {
            NumberClass FirstNumber = new NumberClass();
            NumberClass SecondNumber= new NumberClass();
            FirstNumber.Num = Numsetter();
            SecondNumber.Num = Numsetter();
            string mode;
          Console.WriteLine("For addition write +\nFor subtractiion write -\nFor multiplication write *\nFor division write /\nIf you want to change the first number write num1 and for the second one num2");
            for (; ; ) {
                mode = Console.ReadLine();  
                switch (mode)
                {
                    case "+":
                        Console.WriteLine(FirstNumber.Num=(FirstNumber.Num + SecondNumber.Num));
                        break;
                    case "-":
                        Console.WriteLine(FirstNumber.Num = (FirstNumber.Num - SecondNumber.Num));
                        break;
                    case "*":
                        Console.WriteLine(FirstNumber.Num = (FirstNumber.Num * SecondNumber.Num));
                        break;
                    case "/":
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
                        break;
                }
                if (mode != "+" & mode != "-" & mode != "*" & mode != "/" & mode != "num1" & mode != "num2") {
                    break;
                }
            }
        }
       public static double Numsetter()
        {
            Console.WriteLine("Please enter your number");
            float number = float.Parse(Console.ReadLine());
            return number;
        }
    }
}
