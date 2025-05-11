using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Tämä ohjelma kertoo huoneiston asuinpinta-alan ja muut tilat kun annat huoneiden määrän ja huoneiden mitat ja nimet. Lopulta ohjelma tulostaa
        // huoneet aakkosjärjestyksessä.

        Console.WriteLine("Kuinka monta huonetta haluat käsitellä?");
        int huoneidenMaara = int.Parse(Console.ReadLine());

        List<Huone> huoneet = new List<Huone>();

        double asuinneliot = 0;
        double muutNeliot = 0;

        for (int i = 0; i < huoneidenMaara; i++)
        {
            Console.WriteLine($"\nHuone {i + 1}:");

            Console.Write("Anna huoneen nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Anna huoneen pituus (metreinä): ");
            double pituus = double.Parse(Console.ReadLine());

            Console.Write("Anna huoneen leveys (metreinä): ");
            double leveys = double.Parse(Console.ReadLine());

            Console.Write("Anna huoneen korkeus (metreinä): ");
            double korkeus = double.Parse(Console.ReadLine());

            double pintaAla = pituus * leveys;
            bool onAsuin = korkeus >= 1.9;

            if (onAsuin) //true
            {
                asuinneliot += pintaAla;
            }
            else
            {
                muutNeliot += pintaAla;
            }
            huoneet.Add(new Huone(nimi, pintaAla, onAsuin));

        } // for looppi looppuu tähän

        // Lajitellaan huoneet nimen mukaan aakkosjärjestykseen
        huoneet.Sort((a, b) => a.Nimi.CompareTo(b.Nimi));

        Console.WriteLine("\nLaskennan tulokset: ");
        Console.WriteLine($"Asuinneliöt: {asuinneliot:F2} m²");
        Console.WriteLine($"Muut neliöt: {muutNeliot:F2} m²");

        Console.WriteLine("\nHuonelista (aakkosjärjestyksessä): ");
        foreach (var huone in huoneet)

        {
            string tyyppi = huone.OnAsuin ? "Asuinhuone" : "Muu huone";
            // saa kirjoittaa eri tavalla:
            /*
            string tyyppi;
            if (huone.OnAsuin)
            {
            tyyppi = "Asuinhuone";
            }
            else
            {
            tyyppi = "Muu huone";
            }
            */
            Console.WriteLine($"{huone.Nimi}: {huone.PintaAla:F2} m² ({tyyppi})");
        }

        Console.WriteLine("\nPaina Enter lopettaaksesi.");
        Console.ReadLine();
    }
}



class Huone
{
    public string Nimi { get; set; }
    public double PintaAla { get; set; }
    public bool OnAsuin { get; set; }

    public Huone(string nimi, double pintaAla, bool onAsuin)
    {
        Nimi = nimi;
        PintaAla = pintaAla;
        OnAsuin = onAsuin;
    }
}