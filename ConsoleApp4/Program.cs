using System.Reflection.Emit;

namespace ConsoleApp4
{
    internal class Program
    {
        static bool czypotega3(int value)
        {
            while (value != 1)
            {
                if (value % 3 == 0)
                {
                    value = value / 3;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            /*
            int poczatek = 0;
            int koniec = 100;
            Random losowaLiczba = new Random();
            int losowaLiczba1 = losowaLiczba.Next(poczatek, koniec);
            Console.WriteLine("podaj liczbe miedzy 1 a 100:");
            int b = int.Parse(Console.ReadLine());
            do
            {
                if (losowaLiczba1 > b)
                {
                    Console.WriteLine("Podana liczba jest za duża");
                    b = int.Parse(Console.ReadLine());
                }
                else if (losowaLiczba1 < b)
                {
                    Console.WriteLine("Podana liczba jest za mała");
                    b = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Zgadłeś");
                }
            } while (losowaLiczba1 != b);

            */


            
            Console.WriteLine("Podaj 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");
            int a = int.Parse(Console.ReadLine());
            
            if (a == 1)
            {
                Console.Write("Podaj 1 liczbę: ");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.Write("Podaj 2 liczbę: ");
                int liczba2 = int.Parse(Console.ReadLine());
                int suma = liczba1 + liczba2;
                Console.WriteLine($"{liczba1} + {liczba2} = {suma}");
            } else if (a == 2)
            {
                Console.Write("Podaj 1 liczbę: ");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.Write("Podaj 2 liczbę: ");
                int liczba2 = int.Parse(Console.ReadLine());
                int roznica = liczba1 - liczba2;
                Console.WriteLine($"{liczba1} - {liczba2} = {roznica}");
            } else if (a == 3)
            {
                Console.Write("Podaj 1 liczbę: ");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.Write("Podaj 2 liczbę: ");
                int liczba2 = int.Parse(Console.ReadLine());
                int iloczyn = liczba1 * liczba2;
                Console.WriteLine($"{liczba1} * {liczba2} = {iloczyn}");
            } else if (a == 4)
            {
                Console.Write("Podaj 1 liczbę: ");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.Write("Podaj 2 liczbę: ");
                int liczba2 = int.Parse(Console.ReadLine());
                if (liczba2 == 0)
                {
                    Console.WriteLine("Nie można dzielić przez zero");
                } else{
                    int iloraz = liczba1 / liczba2;
                    Console.WriteLine($"{liczba1} * {liczba2} = {iloraz}");
                }
            }

            /*
            switch(a)
            {
                case 1:
                    Console.WriteLine("Podaj 1 liczbę");
                    int liczba1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj 2 liczbę");
                    int liczba2 = int.Parse(Console.ReadLine());
                    int suma = liczba1 + liczba2;
                    Console.WriteLine($"{liczba1} + {liczba2} = {suma}");
                    break;
                case 2:
                    Console.WriteLine("Podaj 1 liczbę");
                    int liczba3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj 2 liczbę");
                    int liczba4 = int.Parse(Console.ReadLine());
                    int roznica = liczba3 - liczba4;
                    Console.WriteLine($"{liczba3} - {liczba4} = {roznica}");
                    break;
            }
            */

                /* Console.WriteLine("Hello, World!");
                 int liczba1 = 1;
                 int liczba2 = 1;
                 for (int i = 0; i < 10; i++)
                 {
                     int temp = liczba1 + liczba2;
                     Console.WriteLine(temp);
                     liczba1 = liczba2;
                     liczba2 = temp;
                */
                //Console.WriteLine(czypotega3(81));
        }
        
    }
}