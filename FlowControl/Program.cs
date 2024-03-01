namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Determine Price Category");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DeterminePriceCategory();
                        break;
                    case "0":
                        programRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static void DeterminePriceCategory()
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 20)
                {
                    Console.WriteLine("Youth Price: 80 SEK");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Senior Price: 90 SEK");
                }
                else
                {
                    Console.WriteLine("Standard Price: 120 SEK");
                }
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a valid number.");
            }
        }
    }
}
