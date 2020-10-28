using System;
using System.Collections.Generic;
using System.Text;

namespace Metody
{
    public abstract class Figura    // Klasa abstrakcyjna   Nie mozna tworzyć obiektów klas abstrakcyjnych
    {
        protected ConsoleColor kolor;

        public Figura(ConsoleColor k1)
        {
            kolor = k1;
        }
        public override string ToString()
        {
            return string.Format("Kolor {0} Pole {1}", kolor, Pole());
        }

        public abstract double Pole();  // metoda abstrakcyjna - bez ciała. Ciało w klasach pochodnych
    }
}