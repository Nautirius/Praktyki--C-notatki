using System;
using System.Collections.Generic;
using System.Text;

namespace Metody
{
    class Kwadrat
    {
        // Elementy danych:
        protected int bok;                // = 5; // Domyślnie pola klasy są prywatne   // Protected udostępnia obiekt dla klas pochodnych
        protected ConsoleColor kolor;     // = ConsoleColor.Green;    // typ wyliczeniowy - Green dostępny na liście typu wyliczeniowego ConsoleColor
        //ConsoleColor kolor2; = ConsoleColor.Blue;


        public int Bok  // Właściwość dla pola bok, składa się z dwóch "metod" wykonawczych - akcesorów get i set. Ma dostęp publiczny i typ taki sam, jak pole, którego dotyczy
        {
            get { return bok; }     // wykonywany, jeżeli właściwość użyto do odczytu, można mu ustawić private, by przypisywanie było możliwe tylko w klasie
            set { bok = value; }    // wykonywany, jeżeli coś się przypisuje do właściwości, value - wartość przypisywana podczas wywołania właściwości // można za jego pomocą sprawdzć, czy przypisywana wartość jest poprawna
        }
        //public int Bok { get; private set; } // uproszczona właściwosć - kiedy nie wykonuje innych operacji (wtedy bok => Bok w całym kodzie)

        // Elementy funkcyjne:
        public static int liczbaKwadratow;  // Publiczne pole statyczne
        public Kwadrat(int bok1, ConsoleColor kolor1)   // Konstruktor - ta sama nazwa, co klasa. Jeżeli nie jest zdefiniowany, użyty jest domyślny, bez argumentów - przyjmowane wartości domyślne
        {
            bok = bok1;
            kolor = kolor1;
            liczbaKwadratow++;
        }
        public Kwadrat()    // Konstruktor domyślny 
        {
            liczbaKwadratow++;
        }
        static Kwadrat()        // Konstruktor statyczny - nie ma modyfikatorów dostępu ani argumentów. Wywołany automatycznie przed utworzeniem obiektów
        {
            liczbaKwadratow = 0;
        }
        public Kwadrat(Kwadrat kopia)   // Konstruktor kopiujący
        {
            this.bok = kopia.bok;   // this - dla składowej bok bieżącego obiektu przypisz argument obiektu, który kopiujemy
            this.kolor = kopia.kolor;
            liczbaKwadratow++;
        }
        protected virtual int ObliczPole()    // Metoda obliczajaca pole kwadratu   // protected - udostępnia metodę dla klas pochodnych
        {
            return bok * bok;
        }
        public void RysujKwadrat()
        {
            Console.ForegroundColor = kolor;    // właściwość dla koloru znaków
            //Console.BackgroundColor = kolor2;
            for (int i = 1; i <= bok; i++)
            {
                for (int j = 1; j <= bok; j++)
                    Console.Write(" * ");
                Console.WriteLine();
            }
        }
        public string InformacjeOKwadracie()    // Metoda wyświetlająca informacje o kwadracie
        {
            return String.Format("Bok {0} Kolor {1} Pole {2}", bok, kolor, ObliczPole());
        }
        public static Kwadrat MaxPole(Kwadrat[] tab)    // składowe statyczne nie wymagają utworzenia obiektów, ponieważ doyczą całej klasy, a nie wybranego obiektu. Metoda przyjmuje tablice klasy kwadrat
        {
            Kwadrat maxKwadrat = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i].bok > maxKwadrat.bok)
                {
                    maxKwadrat = tab[i];
                }
            }
            return maxKwadrat;
        }
        public override string ToString()    // Modyfikator override przysłania (nadpisuje) wirtualną metodę ToString() z klasy bazowej
        {
            return String.Format("Bok {0} Kolor {1} Pole {2}", bok, kolor, ObliczPole());
        }
        //public override bool Equals(Object obj) // Object - musimy podać nazwę klasy Object, bo jest ona klasą nadrzędną
        //{
        //    Kwadrat kObj = obj as Kwadrat;  // as pozwala rzutować typ obiektu obj jako Kwadrat, kObj będzie już klasy Kwadrat
        //    if (kObj == null)   // jeśli by się nie udało
        //        return false;
        //    else
        //        return this.bok == kObj.bok && this.kolor == kObj.kolor;    // zwraca wartość logiczną
    }
}
