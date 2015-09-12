using System;

namespace ImplementBiDictionary
{
    class Program
    {
        static int[] nullcase = new int[0];
        static void Main(string[] args)
        {
            var distances = new BiDictionary<string, string, int>();
            distances.Add("Sofia", "Varna", 443);
            distances.Add("Sofia", "Varna", 468);
            distances.Add("Sofia", "Varna", 490);
            distances.Add("Sofia", "Plovdiv", 145);
            distances.Add("Sofia", "Bourgas", 383);
            distances.Add("Plovdiv", "Bourgas", 253);
            distances.Add("Plovdiv", "Bourgas", 292);
            var distancesFromSofia = distances.FindByKey1("Sofia"); // [443, 468, 490, 145, 383]
            Console.WriteLine(String.Join(" ,", distancesFromSofia));

            var distancesToBourgas = distances.FindByKey2("Bourgas"); // [383, 253, 292]
            Console.WriteLine(String.Join(" ,", distancesToBourgas));

            var distancesPlovdivBourgas = distances.Find("Plovdiv", "Bourgas"); // [253, 292]
            Console.WriteLine(String.Join(" ,", distancesPlovdivBourgas));

            var distancesRousseVarna = distances.Find("Rousse", "Varna"); // []
            Console.WriteLine(String.Join(" ,", distancesRousseVarna ?? nullcase));

            var distancesSofiaVarna = distances.Find("Sofia", "Varna"); // [443, 468, 490]
            Console.WriteLine(String.Join(" ,", distancesSofiaVarna));

            bool test = distances.Remove("Sofia", "Varna"); // true
            Console.WriteLine(test);
           
            var distancesFromSofiaAgain = distances.FindByKey1("Sofia"); // [145, 383]
            Console.WriteLine(String.Join(" ,", distancesFromSofiaAgain));

            var distancesToVarna = distances.FindByKey2("Varna"); // []
            Console.WriteLine(String.Join(" ,", distancesToVarna ?? nullcase));

            var distancesSofiaVarnaAgain = distances.Find("Sofia", "Varna"); // []
            Console.WriteLine(String.Join(" ,", distancesSofiaVarnaAgain ?? nullcase));
        }
    }
}
