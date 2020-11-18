using System;

namespace Operazioni
{
    public class Calcoli
    {
        public static double Variabile()
        {
            Console.WriteLine("Inserire il numero:");
            double n = Convert.ToDouble(Console.ReadLine());
            return n;
        }
        public static string Operazione()
        {
            Console.WriteLine("Quale operazione vuoi eseguire?(somma=+, differenza=-, moltiplicazione=*; divisione=/).");
            string scelta = Console.ReadLine();
            return scelta;
        }


        public static double? Scelta(double a, double b,  string scelta)
        {
            
            double? risultato = 0;

            switch (scelta)
            {
                case "+":
                case "somma":
                    risultato = a + b;
                    break;

                case "-":
                case "differenza":
                    risultato = a - b;
                    break;

                case "*":
                case "moltiplicazione":
                    risultato = a * b;
                    break;

                case "/":
                case "divisione":
                    risultato = a / b;
                    break;

                default:
                    Console.WriteLine("Errore.");
                    break;
            }
            return risultato;
        }

    }
}
