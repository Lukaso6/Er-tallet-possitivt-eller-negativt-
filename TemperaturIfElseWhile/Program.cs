using System;


namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;

            while (!validInput)
            {

                Console.Write("Skriv inn temperaturen: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int temperature))
            {
                if (temperature > 0)
                {
                    Console.WriteLine("Temperaturen er pluss." );
                }
                else if (temperature < 0)
                {
                    Console.WriteLine("Temperaturen er minus.");
                }
                else
                {
                    Console.WriteLine("Temperaturen er null.");
                }
                    validInput = true;
                }
            else
            {
                Console.WriteLine("Ugyldig format");

            }

            Console.ReadKey();
        }
    }
}
}


//oppgave1 - her brukes if/else int.Parse()/TryParse()
//lag et program som leser inn et tall, en temperatur, fra en bruker
//programmet ditt skal så skrive ut om det er pluss, minus eller null 

//For å parse fra string til en int må det parses. (Når vi leser fra Console. Console.ReadLine()). Om man bruker int.Parse(), vi programmet krasje om det ikke er en numerisk verdi inntastet
//Bruk derfor metoden TryParse() https://www.tutorialspoint.com/chash-int-tryparse-method

//Oppgave 2
//Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet.


//Oppgave 3 - bruk av en loop - while
//Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet, som i oppgave 2. Brukeren skal så få mulighet til å 
//taste inn en verdi, helt til at en gyldig verdi er inntastet. while er et godt valg av loop her. https://www.programiz.com/csharp-programming/do-while-loop

//oppgave 4
//Leg det hele i Git. Public repo. Send linken i oppgave i teams.