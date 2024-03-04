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
                Console.WriteLine("2. Repeat User Input Ten Times");
                Console.WriteLine("3. Extract Third Word");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DeterminePriceCategory();
                        break;
                    case "2":
                        RepeatInputTenTimes();
                        break;
                    case "3":
                        ExtractThirdWord();
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

        static void ExtractThirdWord()
        {
            Console.Write("Enter a sentence with at least 3 words: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            if (words.Length >= 3)
            {
                string thirdWord = words[2];
                Console.WriteLine("Third Word: " + thirdWord);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a sentence with at least 3 words.");
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

        static void RepeatInputTenTimes()
        {
            Console.Write("Enter text to repeat ten times: ");
            string input = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}. {input}");
            }
        }
    }
}
