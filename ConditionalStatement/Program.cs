using static System.Console;
namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nested IF
            //Task 1 read two numbers from user
            // compare adn print the highest number

            Write("Enter the first number:");
            double firstNumber = double.Parse(ReadLine());
           
            Write("Enter the second number:");
            double secondNumber = double.Parse(ReadLine());

            // Compare the numbers
            double highestNumber = Math.Max(firstNumber, secondNumber);

            // Print the highest number
            WriteLine($"The highest number is: {highestNumber}");


            //Task 2 rad a nmber from user
            // if the number is evan then print the square of the number

            // Ask the user to enter a number
            Write("Enter a number:");
            double number = double.Parse(ReadLine());

            // Check if the number is even or odd
            if (number % 2 == 0)
            {
                // If the number is even, print the square of the number
                double square = number * number;
                WriteLine($"The square of {number} is: {square}");
            }
            else
            {
                // If the number is odd, print that it's an odd number
                WriteLine($"{number} is an odd number.");
            }


            //Task 1: Read / get an integer nuber from user
            //Task 2 : check weher number is even or odd

            Write("Please enter a positive number:");
            int inputNumber = int.Parse(ReadLine());

            if (inputNumber > 0)
            {
                if (inputNumber % 2 == 0)
                {
                    WriteLine("The number entered is even.");
                }
                else
                {
                    WriteLine("The number entered is odd.");
                }
            }
            else
            {
                WriteLine("Please enter a positive number.");

            }

            // if (Condition)

            // == != < >

            /*int number;
            Write("Enter any intiger number: ");
            number = int.Parse(ReadLine());//"25" -> 25

            if (number > 0)
            {
                WriteLine("Positive Number.");
                WriteLine($"Number is {number}");
            }
            else if (number < 0)
            {
                WriteLine("Negative Number");
                WriteLine($"Number is {number}");
            }
            else
            {
                WriteLine($"Number is {number}");
            }*/

            
            int age = 18;

            // if(age == 18) // true
            // if(age > 12) //true
            // if(age < 60) //true
            // if(age < 18) // false
            //if(age != 18)//false
            //if(age <= 60)
            //if(age >= 60)
            //if((age == 18) || (age < 18))

            string gender = "Female";
            //if((gender  == "Female") && (age < 18)) 
            /*int num1;
            int num2;
            int result;

            Write("Number 1: ");
            num1 = int.Parse(ReadLine());
            
            Write("Number 2: ");
            num2 = int.Parse(ReadLine());

            result = num1 + num2; 

            WriteLine($"{num1} + {num2} = {result}");*/


            ReadKey();
        }
    }
}
