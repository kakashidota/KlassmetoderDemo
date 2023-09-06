using System;
using System.Threading.Channels;


namespace KlassmetoderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSOLE *************************************************************************
            //Console - Found in "System" namespace
            //Allows for interaction with the console
            //Commonly used methods : WriteLine(), ReadLine(), Clear()
            /*    Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.Write(name);*/

            //MATH **************************************************************************
            //Math - Found in "System" namespace
            //Provides mathematical functions
            //Commonly used methods: Math.Abs(), Math.Round(), Math.Floor() Math.Ceiling
            /*  Console.WriteLine("Enter a number");
              double number = double.Parse(Console.ReadLine());
              double sqrt = Math.Sqrt(number);
              Console.WriteLine("The square root of your number is: " + sqrt);*/


            //Random ************************************************************************
            //Random - Found in "System" namespace
            //Generate random numbers
            //Commonly used Methods: Random.Next(), Random.NextDouble()
            /*                Random random = new Random();
                            int diceroll = random.Next(1, 6);
                            Console.WriteLine(diceroll);
                        */


            //DateTime **********************************************************************
            //DateTime - Found in "System" namespace
            //Used to represent dates and times
            //Can be used to fetch the current date and time with "DateTime.Now()" or to create a specific date/time objects.
            //Commonly used methods: DateTime.AddDays() 
            /*            Console.WriteLine("Enter a date for an event");
                        string event1 = Console.ReadLine();
                        Console.WriteLine($"Remeber: {event1} on {DateTime.Now.DayOfWeek}");*/



            //String *************************************************************************
            //Found in "System" namespace
            //Represents a sequences of characters
            //Contains many methods for string manipulation like: SubString(), IndexOf(), Replace(), ToLower(), ToUpper()
            /*   Console.WriteLine("Enter a sentence or a word");
               string sentence = Console.ReadLine();
                char[] charArray = sentence.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine($"The sentenced revered is: {new string(charArray)}");*/

            /*          string sentence = "Fuck you";
                      bool containsBadWord = sentence.Contains("Fuck");

                      if (containsBadWord)
                      {
                          Console.WriteLine("Ajajaja så får man inte säga!");
                      }
                      else
                      {
                          Console.WriteLine("Ditt medelande innehöll inga fula ord");
                      }


                      Console.WriteLine("Skrik något");
                      string bigLetters = Console.ReadLine();
                      string smallLetters = bigLetters.ToLower();
                      Console.WriteLine(smallLetters);
          */
            //Array ***********************************
            //Found in "System" Namespace
            //Represents "list" of elements
            //Provides methods for creating, manipulating and searching Arrays.
            double[] numbers = new double[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;

            Console.WriteLine("The numbers you entered in reversed order is the following: ");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
                sum += numbers[i];
            }

            Console.WriteLine(sum);


        }
    }
}