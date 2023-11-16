/* There are at least seven logic errors in this code and many bad design choices. 
    Feel free to comment or directly edit your changes but do not merge your branch with main! */ 

using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        try
        {
            Console.Write("Enter the first number: ");
            //String input1=Console.Readline();
            //int num1=input1.Parse();
            int num1 = Console.ReadLine(); //
            

            Console.Write("Enter the second number: ");
            //String input2=Console.ReadLine();
            //int num2=input2.Parse()
            int num2 = Console.ReadLine(); //

            Console.WriteLine("Select operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0]; //here I think it is better to directly using string to store operation 

            CalculatorLogic calculatorLogic = new CalculatorLogic();
            // 

            int result = calculatorLogic.PerformCalculation(num1, num2); // 
            //int result=calculatorLogic.PerformCalculation(num1,num2,operation);

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}"); // 
        }
    }
}

class CalculatorLogic
{   //this result may be printed in this method so it is not necessary to return a value
    public int PerformCalculation(int num1, int num2, char operation)
    {
        int result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // *
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                    //Here 0 will be returned.
                }
                break;
            default:
                // * 
                Console.WriteLine("Error: Invalid operation selected.");
                //
                break;
        }

        return result;
    }
}

class CalculatorUtility
{
    // * 
    public string ConvertToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 10);
    }
}
