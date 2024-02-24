namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that allows a user to play a game where they must guess what your favorite number is:
            //initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:

            int favNum = 23;
            Console.WriteLine("Hello!\nLet's play a guessing game. Can you input what you think my favorite number is?");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput > favNum)
            {
                Console.WriteLine("Sorry, that number is to high.");
            }
            else if (userInput < favNum) 
            {
                Console.WriteLine("Sorry, that number is to low.");
            
            }
            else 
            {
                Console.WriteLine($"Yes! {favNum} is my favorite number!");
            
            }






        }

    }
}
