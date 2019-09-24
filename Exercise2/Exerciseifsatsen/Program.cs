using System;

namespace Exerciseifsatsen
{
    class Program
    {
        static void Main(string[] args)
        {
         //1. Kontrollera värdet (del 1)
 
            /*{
                //Skapa ett program som ställer frågan ”Är det fint väder?”.
                Console.WriteLine("Är det fint väder? Svara j för ja och n för nej: ");
                string input = Console.ReadLine();
                //Om användaren svara ”j” skriver programmet ut ”Vi går på picknick!”.
                if (input == "j") 
                {
                    Console.WriteLine("Vi går på picknick!");
                }
                //Annars händer ingenting.
                else 
                {
                    Console.WriteLine("");
                }
            }*/
 
            //Kontrollera värdet (del 2)
            
            /*{
                Console.WriteLine("Är det fint väder? Svara j för ja och n för nej: ");
                string input = Console.ReadLine();
                //Om användaren svara ”j” skriver programmet ut ”Vi går på picknick!”.
                if (input == "j") 
                {
                    Console.WriteLine("Vi går på picknick!");
                }
                else if (input == "J") 
                {
                    Console.WriteLine("Vi går på picknick!");
                }
                //lägg till att användaren kan svara ”n”. Då skriver programmet ut ”Vi stannar inne och läser en bok”.
                    if (input == "n")
                    {
                        Console.WriteLine("Vi stannar inne och läser en bok.");
                    }
                    //Det ska inte spela någon roll om användaren matar in stor eller liten bokstav..
                    else if (input == "N")
                    {
                        Console.WriteLine("Vi stannar inne och läser en bok.");
                    }
                else 
                {
                    Console.WriteLine("");
                }  
            }*/

            //Kontrollera värdet (del 3)
            /*{
                Console.WriteLine("Är det fint väder? Svara j för ja och n för nej: ");
                string input = Console.ReadLine();
                //Om användaren svara ”j” skriver programmet ut ”Vi går på picknick!”.
                if (input == "j") 
                {
                    Console.WriteLine("Vi går på picknick!");
                }
                else if (input == "J") 
                {
                    Console.WriteLine("Vi går på picknick!");
                }
                //lägg till att användaren kan svara ”n”. Då skriver programmet ut ”Vi stannar inne och läser en bok”.
                    if (input == "n")
                    {
                        Console.WriteLine("Vi stannar inne och läser en bok.");
                    }
                    //Det ska inte spela någon roll om användaren matar in stor eller liten bokstav..
                    else if (input == "N")
                    {
                        Console.WriteLine("Vi stannar inne och läser en bok.");
                    }
                //Gör så att om användaren matar in något annat än ”J”, ”j”, ”n”, ”N” så skriver programmet ut ”Jag förstår inte!”.
                else 
                {
                    Console.WriteLine("Jag förstår inte!");
                }            
            }*/
 
            //2. Felaktig if-sats
            /*- Något stämmer inte riktigt med följande if-sats:
                int var = 10;
                if (var = 10);
                Console.WriteLine("Den är 10!");
            Fundera över följande: När vi försöker kompilera koden så får vi
            ett felmeddelande, varför får vi just detta felmeddelande? Den gör om var till bool
            för att det är if så ska det vara true/false.
            Skriv om koden så att den blir rätt!*/
            /*{
                int var = 10;
                if (var == 10)
                {
                Console.WriteLine("Den är 10!");
                }
            }*/ 
        }
    }
}