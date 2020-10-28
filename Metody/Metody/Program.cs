using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Metody
{
    // Definicja klasy
    //[atrybuty][modyfikatory] class [Nazwa] [:lista elementów bazowych]    // Modyfikatory - dostęp lub rodzaj klasy    :NazwaKlasyBazowej(dziedziczenie) lub interfejsów
    //{
    //      ciało klasy
    //}
    struct Prostopadloscian // Struktura jest typem wartościowym (klasa jest referencyjnym), nie może dziedziczyć po klasie, ani być przedmiotem dziedziczenia. Można implementować interfejsy
    {                       // Każda struktura może być klasą, ale nie każda klasa może być strukturą. Struktury do małych ilości danych, a klasy do duzych ilości danych
        double bokA;    // Składowe struktury nie mogą być inicjalizowane w momencie deklarowania
        double bokB;
        public double Wysokosc { get; set; }
        public Prostopadloscian(double a1, double b1, double h1)    // Nie można deklerować konstruktora bez argumentów
        {
            bokA = a1;
            bokB = b1;
            Wysokosc = h1;
        }
        double obliczObjetosc()
        {
            return bokA * bokB * Wysokosc;
        }
        public string Informacje()
        {
            return String.Format("{0,2} x {1,2} x {2,2} = {3,2}", bokA, bokB, Wysokosc, obliczObjetosc());
        }
    }
    public class Pojazd // Klasa bazowa dla klas niżej
    {
        public virtual void Jedzie()    // Nadpisanie metody
        {
            Console.WriteLine("Pojazd jedzie");
        }
    }
    public class Samochod : Pojazd  // Klasa dziedziczy po klasie Pojazd
    {
        public override void Jedzie()   // Nadpisanie metody
        {
            Console.WriteLine("Samochód jedzie");
        }
    }
    public class Pociag : Pojazd
    {
        public override void Jedzie()
        {
            Console.WriteLine("Pociąg jedzie");   
        }
    }
    class Program
    {
        // Definicja  metody
        //[modyfikatory] [typ zwracanej wartości] [Nazwa](lista argumentów)
        //{
        //    ciało
        //    return;
        //}
        static double NaCelsjusza(double x)
        {
            double C;
            C = 5.0 / 9.0 * (x - 32);
            return C;
        }
        static void Dodaj(ref int x)    // void, gdy nic nie zwraca, ref - modyfikator przed zmienną na liście argumentów, zmiany widoczna na zewnątrz metody
        {
            x++;
            Console.WriteLine("Argument z wnętrza metody: " + x);
        }
        static int DodajLosowe(out int x, out int y)    // Przekazywanie referencyjne przez metodę out, można użyć argumenty na zewnątrz
        {
            Random rand = new Random();
            x = rand.Next(1, 101);
            y = rand.Next(1, 101);
            return x + y;
        }
        static double ObliczDelte(double a, double b = 0, double c = 0) // Domyślne wartości argumentów, muszą być na końcu
        {
            return Math.Pow(b, 2.0) - 4 * a * c;
        }
        static string Test()    // Metody przeciążone - kilka wersji metody, wybierana ta, która pasuje dokładniej, niejawna konwersja argumentów działa
        {
            return "Metoda bez argumentów";
        }
        static string Test(int x = 0)
        {
            return "Liczba całkowita";
        }
        static string Test(string x, int y)
        {
            return "Liczba string i liczba całkowita";
        }
        static int Silnia(int n)
        {
            if (n <= 1) return 1;
            else return n * Silnia(n - 1);
        }
        static double ZadaniePierwsze(double x, double y, double a, double b)   // Zadanie 1
        {
            double dlugosc = Math.Sqrt((Math.Pow((a - x), 2.0) + Math.Pow((b - y), 2.0)));
            return dlugosc;
        }
        static string ZadanieDrugie(string s, out int suma) // Zadanie 2
        {
            string tekstWynikowy = String.Empty;
            suma = 0;
            foreach(char znak in s)
            {
                if(znak >= '0' && znak <= '9')
                {
                    suma += znak - 48;                      
                }
                else
                {
                    tekstWynikowy += znak;
                }
            }
            return tekstWynikowy;
        }
        static void MnozWektor(int[] wektor, int mnoznik)
        {   
            for (int i = 0; i < wektor.Length; i++)
            {
                wektor[i] = wektor[i] * mnoznik;
            }
        }
        static void Main(string[] args)
        {
            //double C, F;
            //Console.WriteLine("Podaj temp. w stopniach Fahrenheita");
            //F = double.Parse(Console.ReadLine());
            //C = Program.NaCelsjusza(F); // Odwołanie do metody
            //Console.WriteLine(C);

            //int liczba = 10;
            //Console.WriteLine("Przed wywołaniem metody: " + liczba);
            //Dodaj(ref liczba);  // modyfikator ref przed zmienną - zmiany widziane na zewnątrz metody
            //Console.WriteLine("Po wywołaniu metody: " + liczba);

            //int a, b;   // Brak inicjalizacji
            //double suma = DodajLosowe(out a, out b);    // Metoda out; a, b - argumenty referencyjne - można je użyć na zewnątrz            
            //Console.WriteLine("Suma={0} a={1} b={2}", suma, a, b);
            //Console.WriteLine("Wpisz liczbę dziesiętną");
            //double liczba;
            //if (Double.TryParse(Console.ReadLine(), out liczba))    // Jeśli się uda, metoda TryParse zwróci True, argument metody out pełni funkcję wyjścia, jeśli się uda
            //{
            //    suma += liczba;
            //    Console.WriteLine("Suma={0}", suma);
            //}
            //else
            //{
            //    Console.WriteLine("Niepoprwana liczba");
            //}
            //Console.WriteLine(ObliczDelte(1, 2, -1));
            //Console.WriteLine(ObliczDelte(1, 2));
            //Console.WriteLine(ObliczDelte(1));
            //Console.WriteLine(ObliczDelte(-1, c: 10));  // Ominięcie argumentu domyślnego b

            //Console.WriteLine(Test());
            //Console.WriteLine(Test(100));
            //Console.WriteLine(Test("Jan", 10));

            //Console.WriteLine(Silnia(4));

            ////Zadanie 1
            //Console.WriteLine("Podaj x1");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj y1");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj x2");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj y2");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Długość odcinka jest równa {0}", ZadaniePierwsze(x, y, a, b));

            ////Zadanie 2
            //int suma;
            //Console.WriteLine("Podaj string");
            //Console.WriteLine(ZadanieDrugie(Console.ReadLine(), out suma));
            //Console.WriteLine("Suma liczb w stringu: {0}", suma);

            //int[] tab1 = { 10, 20, 30 };
            //int[] tab2 = new int[tab1.Length];
            //Array.Copy(tab1, tab2, tab1.Length);    // tab1 = tab2 to referencja do tego samego miejsca na stosie
            //MnozWektor(tab2, -1);
            //Console.WriteLine("{0,5}{1,5}", "tab1", "tab2");
            //for(int i = 0; i < tab1.Length; i++)
            //{
            //    Console.WriteLine("{0,5}{1,5}", tab1[i], tab2[i]);
            //}          
            //Kwadrat k1 = new Kwadrat(5, ConsoleColor.Green); // Utworzenie obiektu klasy Kwadrat - [NazwaKlasy] [nazwaObiektu] = new [Konstruktor-NazwaKlasy](argumenty do konstruktora)
            //Kwadrat k2 = new Kwadrat(); // Konstruktor domyślny
            //k1.RysujKwadrat();  // Wywołanie metody rysującej kwadrat (w pliku klasy Kwadrat) dla obiektu k1
            //k2.RysujKwadrat();
            //Kwadrat k3 = new Kwadrat(k2);   // Kopiowanie obiektu za pomocą konstruktora kopiującego
            //k3.RysujKwadrat();
            //Console.WriteLine(Kwadrat.liczbaKwadratow); // Odwołanie do zmiennej liczbaKwadratow z konstruktora statycznego

            // Tablica obiektów
            //Kwadrat[] tab = new Kwadrat[3];
            //tab[0] = new Kwadrat(3, ConsoleColor.White);
            //tab[1] = new Kwadrat(4, ConsoleColor.Yellow);
            //tab[2] = new Kwadrat(5, ConsoleColor.Blue);

            //// Inicjalizacja tablicy obiektów
            //Kwadrat[] tab = { new Kwadrat(3, ConsoleColor.White),   // int[] liczby = { 21, 42, 61 };
            //                  new Kwadrat(4, ConsoleColor.Yellow),
            //                  new Kwadrat(5, ConsoleColor.Blue) };
            //foreach (Kwadrat kw in tab)
            //{
            //    kw.RysujKwadrat();
            //}
            //Console.ForegroundColor = ConsoleColor.Gray;
            //foreach (Kwadrat kw in tab)
            //{
            //    Console.WriteLine(kw.InformacjeOKwadracie());
            //}

            //// Lista obiektów
            //List<Kwadrat> listaKwadratow = new List<Kwadrat>(tab);  // List<typ elementów>, (tab) - lista załadowana elementami z tablicy
            //listaKwadratow.Add(new Kwadrat(2, ConsoleColor.DarkGreen));
            //Console.WriteLine("Kwadraty z listy:");
            //foreach (Kwadrat kw in listaKwadratow)
            //{
            //    Console.WriteLine(kw.InformacjeOKwadracie());
            //}

            //Kwadrat k1 = new Kwadrat(2, ConsoleColor.Red);
            //k1.RysujKwadrat();
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine(k1.InformacjeOKwadracie());

            //k1.Bok = 5; // zmiana właściwości pola poprzez użycie właściwości - użyta właściwosć set
            //k1.RysujKwadrat();
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine(k1.InformacjeOKwadracie());
            //Console.WriteLine("Bok kwadratu {0}", k1.Bok); // Odczytanie wartości pola poprzez własściwosc get

            //Kwadrat[] tab = { new Kwadrat(3, ConsoleColor.White),
            //                  new Kwadrat(14, ConsoleColor.Yellow),
            //                  new Kwadrat(5, ConsoleColor.Blue) };
            //foreach (Kwadrat kw in tab)
            //{
            //    Console.WriteLine(kw.InformacjeOKwadracie());
            //}
            //Console.WriteLine();
            //Console.WriteLine("Maksymalny kwadrat to:");
            //Console.WriteLine(Kwadrat.MaxPole(tab).InformacjeOKwadracie()); // Kwadrat.MaxPole(tab) - wywołanie metody statycznej, metoda ta zwraca obiekt - wywołanie metody Info dla zwracanego obiektu

            //DateTime t1 = DateTime.Now;
            //Console.WriteLine("Czas t1: {0:HH:mm:ss}", t1);
            //int licznik = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //    licznik++;
            //Console.WriteLine("Wartość zmiennej licznik {0}", licznik);
            //DateTime t2 = DateTime.Now;
            //Console.WriteLine("Czas t2: {0:HH:mm:ss}", t2);
            //Console.WriteLine("Różnica t2-t1: {0}", t2 - t1);

            //Prostopadloscian[] tab = new Prostopadloscian[4];
            //tab[0] = new Prostopadloscian(2, 1, 4);
            //tab[1] = new Prostopadloscian(2, 2, 2);
            //tab[2] = new Prostopadloscian(3, 3, 3);
            //tab[3] = tab[2];
            //tab[3].Wysokosc = 2.0;  // Struktura jest typem wartościowym - przypisywane są wartości, a nie tworzona referencja
            //foreach (Prostopadloscian p1 in tab)
            //{
            //    Console.WriteLine(p1.Informacje());
            //}

            //bool logiczna = false;
            //Console.WriteLine(logiczna);
            //Console.WriteLine(logiczna.ToString().ToUpper());
            //double x = 23.56, y = 23.56;
            //Console.WriteLine("x = " + x);
            //Console.WriteLine("x =" + x.ToString().Replace(",", ""));
            //Console.WriteLine(x.Equals(y)); // (x == y)

            //Kwadrat[] tab = new Kwadrat[3];
            //tab[0] = new Kwadrat(3, ConsoleColor.White);
            //tab[1] = new Kwadrat(4, ConsoleColor.Yellow);
            //tab[2] = new Kwadrat(4, ConsoleColor.Yellow);
            //foreach (Kwadrat kw in tab)
            //{
            //    Console.WriteLine(kw.ToString());
            //}
            //Console.WriteLine(tab[2].Equals(tab[1]));   // W w klasie Kwadrat nadpisaliśmy metodę Equals() klasy System.Object tak, by pasowała

            //Kwadrat k1 = new Kwadrat(4, ConsoleColor.Yellow);
            //Prostokat p1 = new Prostokat(2, ConsoleColor.Red, 3);

            //Console.WriteLine(k1.ToString());
            //Console.WriteLine(p1.ToString());
            //k1.RysujKwadrat();
            //p1.RysujProstokat();

            List<Pojazd> listaPojazdow = new List<Pojazd>();    // Metody wirtualne nie mogą być prywatne ani statyczne. Polimorfizm (pokrewieństwo klas) można zerwać podmieniając override na new
            listaPojazdow.Add(new Pojazd());
            listaPojazdow.Add(new Samochod());  // Można dodać obiekty innych klas, bo kalsy te dziedziczą
            listaPojazdow.Add(new Pociag());
            foreach (Pojazd p1 in listaPojazdow)
            {
                p1.Jedzie();    // Wykonuje metodę odpowiadającą konkretnym obiektom (o konkretnej klasie)
            }
            Console.ReadKey();
        }
    }
}