namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void OneKtoNegativeOneK() 
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void ThreeToNineNineNine()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static void AreTheTwoNumbersEqual(int numberOne, int numberTwo)
        {
           
           if (numberOne == numberTwo)
            {
                Console.WriteLine("The numbers are the same");
            }
           else
            {
                Console.WriteLine("The numbers are different");
            }
        }
        //Write a method to check whether a given number is even or odd
        static void EvenOrOdd(int mysteryNumber)
        {

            if (mysteryNumber%2==0)
            {
                Console.WriteLine("It's even steven.");
            }
            else
            {
                Console.WriteLine("It's odd, but that's ok.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        static void PositiveOrNegative(int aboveOrBelowZero)
        {

            if (aboveOrBelowZero >= 0)
            {
                Console.WriteLine("It's positive.");
            }
            else
            {
                Console.WriteLine("It's a negative nancy.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static void CanVote()
        {
            Console.WriteLine("Please type your age with the number keys");
            int ageNumber;
            string age = Console.ReadLine();
            bool success = int.TryParse(age, out ageNumber);
            if (ageNumber >= 18 && success)
            {
                Console.WriteLine($"Congrats! You're {ageNumber}, you can vote.");
            }
            else
            {
                Console.WriteLine($"Sorry! You're {ageNumber}, you can't vote just yet.");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void InTheRange()
        {
            Console.WriteLine("Please type a number with the number keys");
            int isNumberInRange;
            string tempNumber = Console.ReadLine();
            bool success = int.TryParse(tempNumber, out isNumberInRange);
            if (isNumberInRange > 10 || isNumberInRange < -10)
            {
                Console.WriteLine($"Your number is not in our range. Better luck next time.");
            }
            else
            {
                Console.WriteLine($"Congrats, your number is in our range! Way to go!");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultiplicationTable()
        {
            
            Console.WriteLine("Please write a number with the number keys");
            var baseNumber = float.Parse(Console.ReadLine());
            for (int i = 1; i <= 12;i++) 
            {
                var product = baseNumber*i;
                Console.WriteLine($"{i} x {baseNumber} is {product}");
            }
        }

            /*Call the methods to test them in the Main method below
            //I'm not sure if I was only supposed to use methods in the main method or if I was allowed to have the console write in the main method. If I can't have a console
              writing in the main method, I'll just add those to the methods and alter the rest*/
            static void Main(string[] args)
        {
            OneKtoNegativeOneK();
            ThreeToNineNineNine();
            Console.WriteLine("Please type a number");
            int equalNumberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type another number");
            int equalNumberTwo = int.Parse(Console.ReadLine());
            AreTheTwoNumbersEqual (equalNumberOne, equalNumberTwo);
            Console.WriteLine("Please type a number");
            int areYouEvenOrOdd = int.Parse(Console.ReadLine());
            EvenOrOdd(areYouEvenOrOdd);
            Console.WriteLine("Please type a number");
            int areYouPositiveOrNegative = int.Parse(Console.ReadLine());
            PositiveOrNegative(areYouPositiveOrNegative);
            CanVote();
            InTheRange();
            MultiplicationTable();
        }
    }
}
