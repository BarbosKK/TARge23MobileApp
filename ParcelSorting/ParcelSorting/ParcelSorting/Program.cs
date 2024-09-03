using System;
using System.Collections.Generic;
using System.Linq;

namespace ParcelSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Näide sisenditest
            string input1 = "60, 120, 100, 75"; // Eeldatav: "Mahub"
            string input2 = "100, 35, 75, 50, 80, 100, 37"; // Eeldatav: "Mahub"
            string input3 = "70, 50, 60, 60, 55, 90"; // Eeldatav: "Ei mahu"

            Console.WriteLine(CheckParcelFit(input1));
            Console.WriteLine(CheckParcelFit(input2));
            Console.WriteLine(CheckParcelFit(input3));
        }

        public static string CheckParcelFit(string input)
        {
            string[] parts = input.Split(',');

            // Loome BoxSize objekti paki mõõtmete jaoks
            BoxSize parcel = new BoxSize
            {
                Length = int.Parse(parts[0].Trim()),
                Width = int.Parse(parts[1].Trim())
            };

            // Arvutame paki diagonaali
            double parcelDiagonal = Math.Sqrt(parcel.Length * parcel.Length + parcel.Width * parcel.Width);

            // Loome nimekirja SortingLineParam objektidest toru laiuste jaoks
            List<SortingLineParam> sortingLines = parts.Skip(2)
                .Select(p => new SortingLineParam { LineWidth = int.Parse(p.Trim()) })
                .ToList();

            // Kontrollime, kas pakk mahub läbi kõikide toru laiuste
            foreach (SortingLineParam line in sortingLines)
            {
                if (parcelDiagonal > line.LineWidth)
                {
                    return "Ei mahu";
                }
            }

            return "Mahub";
        }
    }

    public class BoxSize
    {
        public int Length { get; set; }
        public int Width { get; set; }
    }

    public class SortingLineParam
    {
        public int LineWidth { get; set; }
    }
}