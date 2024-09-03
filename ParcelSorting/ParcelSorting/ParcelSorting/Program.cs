using System;
using System.Collections.Generic;
using System.Linq;

namespace ParcelSorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Näide sisenditest
            string input1 = "60, 120, 100, 75, 30, 25, 33"; //muudetud originaalist mängimiseks ja testimiseks
            string input2 = "100, 35, 75, 50, 80, 100, 37"; 
            string input3 = "70, 50, 60, 60, 55, 90"; 

            // Kontrollime igat sisendit eraldi ja näitame tulemusi
            CheckAndPrintResult("Pakk 1", input1);
            CheckAndPrintResult("Pakk 2", input2);
            CheckAndPrintResult("Pakk 3", input3);
        }

        public static void CheckAndPrintResult(string packageName, string input)
        {
            List<string> results = CheckParcelFit(input);
            Console.WriteLine($"{packageName}:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine(); // tühi rida parema loetavuse jaoks
        }

        public static List<string> CheckParcelFit(string input)
        {
            string[] parts = input.Split(',');

            int firstDimension = int.Parse(parts[0].Trim()); //sisendi esimene number on paki mõõt 1
            int secondDimension = int.Parse(parts[1].Trim()); //sisendi teine number on paki mõõt 2

            // Loome BoxSize objekti paki mõõtmete jaoks
            BoxSize parcel = new BoxSize();

            // Määrame, kumb on Length ja kumb on Width
            if (firstDimension >= secondDimension)
            {
                parcel.Length = firstDimension;
                parcel.Width = secondDimension;
            }
            else
            {
                parcel.Length = secondDimension;
                parcel.Width = firstDimension;
            }

            // Arvutame paki diagonaali
            double parcelDiagonal = Math.Sqrt((parcel.Length)/2 * (parcel.Length)/2 + parcel.Width * parcel.Width);

            // Loome nimekirja toru laiustest
            List<int> pipeWidths = parts.Skip(2)
                .Select(p => int.Parse(p.Trim()))
                .ToList();

            List<string> feedback = new List<string>();
            bool fitsAllTurns = true;

            // Kontrollime iga pöördepunkti
            for (int i = 1; i < pipeWidths.Count; i++)
            {
                int widthBeforeTurn = pipeWidths[i - 1];
                int widthAfterTurn = pipeWidths[i];

                // Arvutame pöördepunkti diagonaali kahe toru laiuse vahel
                double turnDiagonal = Math.Sqrt(widthBeforeTurn * widthBeforeTurn + widthAfterTurn * widthAfterTurn);

                // Kontrollime, kas paki diagonaal on võrdne või suurem kui toru pöördepunkti diagonaal
                if (parcelDiagonal >= turnDiagonal)
                {
                    feedback.Add($"Pöördepunktis pakk diagonaaliga {parcelDiagonal:F2} ei mahu läbi toru {i} pöördepunkti diagonaaliga {turnDiagonal:F2}");
                    fitsAllTurns = false;
                }
                else
                {
                    feedback.Add($"Pöördepunktis pakk diagonaaliga {parcelDiagonal:F2} mahub läbi toru {i} pöördepunkti diagonaaliga {turnDiagonal:F2}");
                }
            }

            // Lõplik tulemus
            if (fitsAllTurns)
            {
                feedback.Add("Lõpptulemus: Mahub");
            }
            else
            {
                feedback.Add("Lõpptulemus: Ei mahu");
            }

            return feedback;
        }
    }

    public class BoxSize
    {
        public int Length { get; set; }
        public int Width { get; set; }
    }
}