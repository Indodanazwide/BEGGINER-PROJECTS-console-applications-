namespace ConsoleApp68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR\n");
            double firstNumber;
            double secondNumber;
            string myOperator;

            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter the first digit: ");
                        firstNumber = double.Parse(Console.ReadLine());

                        if (firstNumber <= 0 || firstNumber >= 0)
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Enter real number only");
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Write("Enter operator: ");
                        myOperator = Console.ReadLine();
                        if (myOperator == "+" || myOperator == "-" || myOperator == "*" || myOperator == "/")
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        //this block is not executed
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Write("Enter the second digit: ");
                        secondNumber = double.Parse(Console.ReadLine());

                        if (secondNumber <= 0 || secondNumber >= 0)
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Enter real number only");
                    }
                }

                double answer;
                if (myOperator == "+")
                {
                    answer = firstNumber + secondNumber;
                    Console.WriteLine($"Your answer is: {answer}");
                }

                if (myOperator == "-")
                {
                    answer = firstNumber - secondNumber;
                    Console.WriteLine($"Your answer is: {answer}");
                }

                if (myOperator == "/")
                {
                    answer = firstNumber / secondNumber;
                    Console.WriteLine($"Your answer is: {answer}");
                }

                if (myOperator == "*")
                {
                    answer = firstNumber * secondNumber;
                    Console.WriteLine($"Your answer is: {answer}");
                }

                Console.WriteLine("Choose C to clear and OFF to turn off the calculator.");

                string option;
                while (true)
                {
                    try
                    {
                        option = Console.ReadLine();
                        if (option == "C")
                        {
                            break;
                        }
                        else if (option == "OFF")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Choose C to clear and OFF to turn off the calculator.");
                        }
                    }
                    catch (Exception ex)
                    {
                        //this block is not executed
                    }
                }

                if (option == "C")
                {
                    continue;
                }
                else if (option == "OFF")
                {
                    break;
                }
            }
        }
    }
}
