// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Runtime.CompilerServices;

///<summary>
///Purpose is to perform simple arithmatic
///</summary>
Console.WriteLine("Enter first number!");
string num1Input = Console.ReadLine();
Console.WriteLine("Enter second number!");
string num2Input = Console.ReadLine();
Console.WriteLine("Choose an operation (Use +, -, *, /)");
string operationChoice = Console.ReadLine();

int num1; 
int num2; 

bool isNumber1 = int.TryParse(num1Input, out num1);
bool isNumber2 = int.TryParse(num2Input, out num2);

if(isNumber1 && isNumber2)
{
        if(operationChoice == "+")
        {
                Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
        }
        else if(operationChoice == "-")
        {
        Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
        }
        else if(operationChoice == "*")
        {
                Console.WriteLine($"{num1} * {num2} = " + num1 * num2);
        }
        else if(operationChoice == "/")
        {
                if(num1 == 0 || num2 == 0)
                {
                        Console.WriteLine("Division by zero is not allowed.");
                }
                else
                {
                       
                        Console.WriteLine($"{num1} / {num2} = " + num1 / num2);
                }
                
        }
        else
        {
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        }
}
else
{
        Console.WriteLine("Wrong Input!");
}

Console.ReadKey();








