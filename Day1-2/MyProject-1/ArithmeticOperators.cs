using System;
class ArithmeticOperators
{

    public void doArithmetricOpration(int firstNumber, int secondNumber)
    {
        int addition = firstNumber + secondNumber;
        int subtraction = firstNumber - secondNumber;
        int multiplication = firstNumber * secondNumber;
        String division = doDivision(firstNumber, secondNumber);

        Console.WriteLine("Addition: " + firstNumber + " + " + secondNumber + " = " + addition + "\n" +
                            "Subtraction: " + firstNumber + " - " + secondNumber + " = " + subtraction + "\n" +
                            "Multiplication: " + firstNumber + " * " + secondNumber + " = " + multiplication + "\n" +
                            division
        );
    }

     string doDivision(int firstNumber, int secondNumber)
    {
        double division;
        String res = "Division: " + firstNumber + " / " + secondNumber + " = ";
        try
        {
            division = (double)firstNumber / (double)secondNumber;
        }
        catch (ArithmeticException e)
        {
            return res + e.Message;
        }
        return res + division;
    }

}