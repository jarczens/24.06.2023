using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj czas w sekundach:");
            int czas = Convert.ToInt32(Console.ReadLine());

            string sformatowanyCzas = FormatujCzas(czas);
            Console.WriteLine(sformatowanyCzas);
        }

        static string FormatujCzas(int czas)
        {
            int godziny = czas / 3600;
            int minuty = (czas % 3600) / 60;
            int sekundy = czas % 60;

            string sGodziny = godziny.ToString("00H");
            string sMinuty = minuty.ToString("00M");
            string sSekundy = sekundy.ToString("00S");

            return $"{sGodziny}:{sMinuty}:{sSekundy}";
        }
    }