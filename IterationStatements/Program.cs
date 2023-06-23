namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Numbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbers()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreEqual(int num1, int num2)



        {
            return num1 == num2;

        }


        //Write a method to check whether a given number is even or odd

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        //Write a method to check whether a given number is positive or negative

        public static string CheckSign(int number)
        {
            if (number > 0)
            {
                return "Positive";
            }
            else if (number < 0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
        }



        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void CheckVotingEligibility()
        {
            Console.WriteLine("candidate's age:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("The candidate is eligible to vote.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible to vote.");
            }
        }


        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Numbers();
            PrintNumbers();
            Console.WriteLine(IsEven(2));
            Console.WriteLine(CheckSign(4));
            CheckVotingEligibility();


        }
    }
}
