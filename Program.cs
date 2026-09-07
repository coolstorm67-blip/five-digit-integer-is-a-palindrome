using System;
class palindrome
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a five-digit integer:");
            string number = Console.ReadLine();
            if (number.Length != 5)
            {
                Console.WriteLine("Error: Please entera five-digit integer.");
                continue;
            }
            if (number[0] == number[4] && number[1] == number[3])
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
            break;
        }
    }
}