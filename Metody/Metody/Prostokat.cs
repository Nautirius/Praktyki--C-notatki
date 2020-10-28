using System;
using System.Collections.Generic;
using System.Text;

namespace Metody
{
    class Prostokat : Kwadrat   // Klasa dziedziczy po klasie Kwadrat. Prostokat klasą pochodną, bo ma więcej elementów opisujących
    {
        int bokB;   // reszta danych definiowana w klasie Kwadrat

        public Prostokat(int b1, ConsoleColor k1, int b2): base(b1, k1) // konstruktor inicjalizujący dla klasy pochodnej, base - elementy z klasy bazowej (Kwadrat)
        {
            bokB = b2;  // inicjalizujemy to, co doszło w klasie pochodnej
        }
        protected override int ObliczPole() // modyfikator dostępności protected i modyfikator override (nadpisujemy metodę z klasy Kwadrat)
        {
            return bok * bokB;
        }
        public void RysujProstokat()
        {
            Console.ForegroundColor = kolor;
            for (int i = 1; i <= bok; i++)
            {
                for (int j = 1; j <= bokB; j++)
                    Console.Write(" * ");
                Console.WriteLine();
            }
        }
        public override string ToString()   // Nadpisujemy metodę ToString() z klasy Kwadrat
        {
            return String.Format("Bok {0} ", bokB) + base.ToString();   // wypisuje podane dane i dołącza to, co wypisuje metoda bazowa (wywołanie metody z klasy bazowej - base.NazwaMetody())
        }   // program automaycznie używa metody ObliczPole() z obecnej klasy Prostokat
    }
}