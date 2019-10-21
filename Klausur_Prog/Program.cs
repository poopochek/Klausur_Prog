using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int auswahl;
            string nochmal;
            do
            {
                Console.WriteLine("Auswahlmenü");
                Console.WriteLine("1: Summe der ganzen Zahlen von a bis b.");
                Console.WriteLine("2: Verflixte 7.");
                Console.WriteLine("3:°C in °F umrechnen.");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.WriteLine("Summe der ganzen Zahlen von a bis b berechnen:");
                    Console.WriteLine("a:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("b:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Die Summe der ganzen Zahlen von " + a + " bis " + b + " ergibt " + VonAbisB(a, b));

                }
                else if (auswahl == 2)
                {
                    Console.WriteLine("Verflixte 7:");
                    Console.WriteLine("Obere Grenze angeben:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Verfl7(c));
                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Temperatur eingeben:");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(d + "°C" + " entsprechen " + GradinFar(d) + "°F");
                    Console.WriteLine(d + "°F" + " entsprechen " + FarinGrad(d) + "°C");


                }




                Console.WriteLine("Neue Zahl umrechnen? (j/n)");
                nochmal = Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");
        }


        static string VonAbisB(int a, int b)
        {
            int z = 0;
            string summe;
            summe = "";
            for (int i = a; i <= b; i++)
            {
                z += i;
                summe = Convert.ToString(z);
            }
            return summe;

        }
        static string Verfl7(int c)
        {
            int z = 0;
            string zahl;
            zahl = "";
            for (int i = 1; i <= c; i++)
            {
                z = i;
                if (z % 7 == 0 || Convert.ToString(z).Contains("7"))
                {
                    Console.WriteLine("---" + z + "---");
                }
                else
                {
                    Console.WriteLine(z);
                }
                Console.ReadLine();
                zahl = Convert.ToString(z);
            }
            return zahl;
        }
        static string GradinFar(int d)
        {
            string far = "";
            double F;
            F = (d * 1.8) + 32;
            far = Convert.ToString(F);
            return far;
        }

        static string FarinGrad(int d)
        {
            string grad = "";
            double G;
            G = Math.Round((d - 32) / 1.8, 1);
            grad = Convert.ToString(G);
            return grad;
        }



    }
}
