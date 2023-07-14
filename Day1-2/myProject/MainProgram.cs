using System;

class MainProgram
{
    static void Main()
    {

        while (true)
        {
            Console.Write("chose any option : \n 1.Arithmetic opration \n 2.Conditional Statment \n 3.Logical Operators \n 0.close the program \n Enter option Number: ");
            int n = int.Parse(Console.ReadLine());
            useMethod(n);
            if (n == 0)
            {
                Console.WriteLine("thanks");
                break;
            }
        }
    }

    static void useMethod(int n)
    {
        switch (n)
        {
            case 1:
                {
                    ArithmeticOperators ap = new ArithmeticOperators();

                    Console.Write($"Enter first Number :");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.Write($"Enter second Number :");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    ap.doArithmetricOpration(firstNumber, secondNumber);
                    Console.ResetColor();

                }
                break;
            case 2:
                {
                    ConditionalStatements cs = new ConditionalStatements();
                    Console.Write("Enter Number :");
                    int num = int.Parse(Console.ReadLine());
                    string res = cs.checkNumber(num);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(res);
                    Console.ResetColor();
                }
                break;
            case 3:
                {
                    LogicalOperators lo = new LogicalOperators();
                    Console.Write("Enter Number :");
                    int num = int.Parse(Console.ReadLine());
                    string res = lo.isDivisible(num);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(res);
                    Console.ResetColor();
                }
                break;
            default:
                {
                    Console.WriteLine("wrong input, please try again ");
                }
                break;
        }
    }
}