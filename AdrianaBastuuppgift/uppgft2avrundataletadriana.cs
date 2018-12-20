using System;

namespace Avrundatalet2
{
    class Programtalet

    //Uppgift 2 Jag använder mig av ConsoleWriteline för att skriva vad användren ska göra
    //Readline och parse för att få information från användaren
    //Använder decimal för att kunna ha decimaler och konvertera det från string
    // med hjälp av Math metoden och Console.WriteLine(nummerdeci.ToString("0.000")); kan jag förbestämt avrunda till tre decimaler


    {
        static void taletskaavrundas2Main(string[] args)
        {// ber anvädaren skriva decimaltal
            Console.WriteLine("Skriv in ett decimal tal" +
                              "");


            string inmatafrananv = Console.ReadLine();
            //tryck enter för att fortsätta

            //här anväder jag inmatning från anvädaren, när hen har skrivit in sitt decimaltal
            //sen så vill jag att hen ska skriva in hur många decimal tal hen vill ha.
            //sen konverterar jag till decimal
            decimal nummerdeci = decimal.Parse(inmatafrananv);
            decimal inmatatfrananv = Convert.ToDecimal(inmatafrananv);
            Console.WriteLine("Hur många decimaler vill du ha?:");
            inmatafrananv = Console.ReadLine();
            int inmat = int.Parse(inmatafrananv);

           // jag använder mig av math method för att avrunda och konverterar talet till string
            decimal avrunda = Math.Round(nummerdeci, inmat);

            Console.WriteLine($"Avrundat: {avrunda}");
            Console.WriteLine(nummerdeci.ToString("0.000"));

           

        }

    }
}
