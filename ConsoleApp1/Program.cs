using System;

class Program
{
    static void Main()
    {
        while (true) // Loop until the user chooses to quit
        {
            
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
                Console.WriteLine("Starting a new game...\n\n");
            else if (choice == "2")
                Console.WriteLine("Loading game...\n\n");
            else if (choice == "3")
                Console.WriteLine("Opening options...\n\n");
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!\n\n");
                break; // Exit the loop to quit the program
            }
            else
                Console.WriteLine("Invalid choice. Please try again.\n\n");
        }
    }
}
