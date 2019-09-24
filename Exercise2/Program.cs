using System;

namespace basicpractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. summan av två heltal
            /*{
                int number1 = 27;
                int number2 = 15;
                int sum = 0;
                sum = number1 + number2;
                Console.WriteLine("The sum is {0}.", number1 + number2);
            } */

            //2. Decimal till heltal - Skapa ett program som omvandlar ett inmatat decimaltal till närmaste heltal.
            /*{
                //Variabler jag kommer att använda
                string num; 
                double num1;
                //Ber användaren om ett tal
                Console.Write("Ange ett decimaltal som ska avrundas: ");
                //Läser in input och gör sträng till tal
                num = Console.ReadLine();
                num1 = double.Parse(num);
                //Gör om decimaltal till heltal
                num1 = Math.Round(num1);
                //Skriver ut värdet
                Console.Write("Ditt tal avrundat blir: " + num1);
                }*/

            //3. Saga med två sträng variabler - Låt användaren mata in två namn. Skriv sedan ut en kort berättelse med dessa två namn. 
            /*{
                Console.WriteLine("Hello! Please write your name ");
                string name = Console.ReadLine();
                Console.WriteLine("Now please write another name ");
                string anothername = Console.ReadLine();
                Console.WriteLine("Once upon a time there was a puppy named " + name + ". It was very scared so it ran to " + anothername + " and was safe.");
            }*/

            //4. Char - Prova att använda olika numeriska värden i UNICODE-tabellen. Vilka slutsatser kan du dra av detta?
            /*{
              char myChar = 'm';
              Console.WriteLine(myChar);  
            }*/

            //5. Inmatning och utmatning
            /*{
                //I denna övning ska du göra ett program som låter användaren mata in sitt namn.
                Console.WriteLine("Hello! What's your name? "); 
                string name = Console.ReadLine();
                //Därefter hälsar du användaren välkommen.
                Console.WriteLine("Hello " + name); 
                //Du ska sedan låta användaren mata in sin ålder och spara undan den i lämplig variabel.
                int age;
                Console.Write("How old are you? ");
                age = Convert.ToInt32(Console.ReadLine());
                //Räkna sedan ut antalet dagar användaren har levt utifrån det angivna åldern. Presentera detta för användaren.
                Console.WriteLine("You have been alive for " + ( age*365 ) + " days.");
                Console.ReadLine();
            }*/ 
        }
    }
}
