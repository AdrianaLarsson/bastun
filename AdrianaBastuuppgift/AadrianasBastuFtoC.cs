using System;

namespace BastuuppgiftFtoC
{
    class FahrtoCProgram
    {// Metoden float som gör uträkningen Fahrenheit till Celsius på min bastu till amerikanen
        // Jag använde mig av float från början, flyttal. Så jag får decimaler.
        // Jag gav namnet inputuserfarhrenheit så det ska bli lättare att veta vilket som är vilket
        // Samma med Celsius
        private static float inputuserfahrenheit;
        private static float celsiusoutput;

        public static float  FahrenheitToCelsisus1(float fahrenheit)
        //Själva metoden heter FaharenheitToCelsius, vilket är relevant till själva uppgiften och cs filen.
        //Men här görs själva uträkningen, nedanför. först skapar jag ju variabler i float 
        // private static float inputuserfahrenheit;
        //private static float celsiusoutput;


        {//Här kommer uträkningen
            
            float celsiusoutput = ((fahrenheit - 32) * 5) / 9;
            return celsiusoutput;//uträkningen kommer till Celsius

        }

        public static void Main(string[] args)
        // Main metod string, det är här själva koden börjar (det är här det händer mest)
     {
            
            // skapar max och min temp och själva korrekta temperaturen, ger dem ett värde.
            //Just för att det ska bli lättare att se vad jag har redskap för att använda i koden.
           
            float correcttemperaturcelsius = 75;
            float mintemperaturecelsius = correcttemperaturcelsius - 2 ;//73 162
            float maxtemperaturecelsius = correcttemperaturcelsius + 3; //75 170
            celsiusoutput = 0;

            bool number = true;// Skapar en bool true/false till try catch
            do
            {
                Console.Write("Write down the temperature in Fahrenheit please! : ");// uppmanar anvädaren skriva in temperatur i
                //Fahrenheit så att det kommer upp vad anvädaren har skrivit och sen görs uträkningen och kommer
                // till Celsius, då lär sig även anvädaren hur mycket det är i Celsius


                celsiusoutput = FahrenheitToCelsisus1(inputuserfahrenheit);// Här anropar jag själva metoden där 
                //uträkningen görs.
            

           
                try // try catch fångar all text, så det kommer upp. Wrong! Write only numbers! Men att det även blir
                // en grad på noll för att om anvädaren skriver text så kommer det visas att de är 0 grader i Fahrenheit
                //Har ingen värde egentligen.
                {
celsiusoutput = FahrenheitToCelsisus1(inputuserfahrenheit);
                   
                    
                    // här anropas metoden FahrenheitToCelsius så att själva uträkningen komemr in i do while koden
                    number = false;
                }



                catch (FormatException)


               
                    {
                        Console.WriteLine(" WRONG! You can just write numbers!");

                    }

                if (celsiusoutput > maxtemperaturecelsius)// jag använder mig av do while loop
                    // här är om anvädaren skriver ett nummer över max temperaturen
                    // Alltså om celsiusoutput är störren än meax temperaturen så skall de komma upp en tex
              

                {
                    Console.WriteLine(" You wrote in Fahrenheit " + inputuserfahrenheit + " The temperature is to high, turn down! It's " + FahrenheitToCelsisus1(inputuserfahrenheit) + " deegres in Celsius");
                    // You wrote in fahrenheit .... och temperaturen är för hög, sänk värmen och sen kommer graderna i Celsius
                    // Det anvädaren skriver i Fahrenhit Kommer varje gång att visas.


                }
                if (celsiusoutput < mintemperaturecelsius)// här är om celsiusouput är mindre än min temperaturen
                    //alltså om anvädaren skriver in för låg temperatur genmföert med mintempreturen i celsius efter uträkningen från fahrenheit
                    // precis samma som ovanför om mans kriver för hög tempretur!




                {
                    Console.WriteLine(" You wrote in Fahrenheit " + inputuserfahrenheit + " Its to low, turn up! Its " + FahrenheitToCelsisus1(inputuserfahrenheit) + 
                                      " deegres inn celsius ");// här kommer texten om anvädaren skriver in för låg temperatur
                    // även vad användaren skrev i fahrenheit och i Celsius




                }

                else if (celsiusoutput == correcttemperaturcelsius)//här är om användaren skriver den korrekta temperturen
                    
                {


                    Console.WriteLine(" You wrote in Fahrenheit " + inputuserfahrenheit + " The temperature is perfect, it's  " + FahrenheitToCelsisus1(inputuserfahrenheit) + " " +
                                      "deegres in Celsius ");// här kommer det att stå garderna i Fahreheit och sedan att det är korrekt tempretur och graderna i Celsius
                    //sälva programmet avslutas! Allt klart!


                }

                else if (celsiusoutput < maxtemperaturecelsius && celsiusoutput > mintemperaturecelsius || celsiusoutput == mintemperaturecelsius || celsiusoutput == maxtemperaturecelsius)
                    // här är om användaren skrivver mellan 164-170 den tempereaturen som är mellan min och max och även om hen skriver in 164 eller 170.
                    // anvädaren ska veta att det är nära och att de är en bra temperatur men inte den perfekta
                {


                    Console.WriteLine(" You wrote in Fahrenheit " + inputuserfahrenheit + " The temperature it's good but not perfect! It's " + FahrenheitToCelsisus1(inputuserfahrenheit) +
                                      " deegres in Celsius ");// här meddelas använadren om att den är mellan eller skrivit in en av max eller min temperaturen. Okej temperatur men inte perfekt.
                    

                }



                    

                


        } while (celsiusoutput > maxtemperaturecelsius || celsiusoutput < mintemperaturecelsius || celsiusoutput != 75);
            //här slutar while loopen, eller koden rättare sagt
            {


                Console.ReadLine();
                }
            }
        }
    }     