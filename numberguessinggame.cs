namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMBER GUESSING GAME. \n");

            Console.WriteLine("Choose your desired range to play at.");

            while (true)
            {
                Console.Write("Minimum value: ");
                int minValue = int.Parse(Console.ReadLine());

                Console.Write("Maximum value: ");
                int maxValue = int.Parse(Console.ReadLine());

                if (maxValue - minValue >= 5)
                {
                    Random random = new Random();
                    int computerRandom = random.Next(minValue, maxValue);

                    Console.WriteLine($"Comp is {computerRandom}\n");

                    while (true)
                    {
                        Console.Write("Choose your choice: ");
                        int userChoice = int.Parse(Console.ReadLine());

                        if (userChoice >= minValue && userChoice <= maxValue)
                        {
                            if (computerRandom == userChoice)
                            {
                                Console.WriteLine("Win!");

                                break;
                            }
                            else if (computerRandom <= userChoice)
                            {
                                Console.WriteLine("Guess lower");
                            }
                            else if (computerRandom >= userChoice)
                            {
                                Console.WriteLine("Guess higher");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your guess is out of range!");
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Choose more separate numbers!");
                }
            }
        }
    }
}
