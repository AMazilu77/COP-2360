using System;

using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter second number: ");
        string input2 = Console.ReadLine();     

        DivideStrings(input1, input2);
    }

     static void DivideStrings(string? input1, string? input2)
    {
            try
    {
        int num1 = Convert.ToInt32(input1);
        int num2 = Convert.ToInt32(input2);

        BigInteger result = num1 / num2;
        Console.WriteLine($"Result of division: {result}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Invalid input format! Please enter valid integers."); 
        
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: Division by zero is not allowed! Only Chuck Norris can divide by zero! Please enter a non-zero second number.");        

    }
    catch (OverflowException)
    {
        Console.WriteLine("Error: The result is too large to handle! 32 bit numbers only Please enter smaller numbers.");        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }


}

}
