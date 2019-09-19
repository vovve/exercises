using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Inmatning och utmatning
            - I denna övning ska du göra ett program som låter användaren
            mata in sitt namn. Därefter hälsar du användaren välkommen. Du
            ska sedan låta användaren mata in sin ålder och spara undan den
            i lämplig variabel. Räkna sedan ut antalet dagar användaren har
            levt utifrån det angivna åldern. Presentera detta för användaren. */

            {
                Console.WriteLine("Hello! What's your name? "); 
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name);            
                int age;
                Console.Write("How old are you? ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have been alive for " + ( age*365 ) + " days.");
                Console.ReadLine();
            }
        }
    }
}
