using System;

namespace Operazioni
{
    public class Calcoli
    {
        public static double Variabile(double n)
        {
            Console.WriteLine("Inserire il numero");
            n = Convert.ToDouble(Console.ReadLine());
            return n;
        }
        
        }
        public static double Scelta(double a, double b)
        {
            Console.WriteLine("Quale operazione vuoi eseguire?");
            string scelta = Convert.ToString(Console.ReadLine());

            /*switch (scelta)
            {
                case "+":
                case "somma":
                    double somma = a + b;
                    return somma;
                    break;
                case "-":
                case "differenza":
                    double differenza = a - b;
                    return differenza;
                    break;
                case "*":
                case "moltiplicazione":
                    double moltiplicazione = a * b;
                    return moltiplicazione;
                    break;
                case "/":
                case "divisione":
                    double divisione = a / b;
                    return divisione;
                    break;
                default:
                    Console.WriteLine("Errore.");
                    break;
            }*/
            if (scelta == "somma" || scelta == "+")
            {
                double somma = a + b;
                return somma;
            }else if(scelta =="differenza" || scelta == "-")
            {
                double differenza = a - b;
                return differenza;
            }else if(scelta == "moltiplicazione" || scelta == "*")
            {
                double moltiplicazione = a * b;
                return moltiplicazione;
            }else if(scelta == "divisione" || scelta == "/")
            {
                double divisione = a / b;
                return divisione;
            }
        }
    }
}
