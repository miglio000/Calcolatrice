﻿using System;
using Operazioni;
namespace Calc1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = Calcoli.Variabile();
            string operatore = Calcoli.Operazione();
            double n2 = Calcoli.Variabile();
            double? risultato = Calcoli.Scelta(n1, n2, operatore);
            Console.WriteLine(risultato);
        }
    }
}
