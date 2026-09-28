namespace extrauppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rita ett flödesdiagram som visar logiken:
            //om temperaturen är under 0 → “Det är minusgrader”, mellan 0–30 → “Normal temperatur”, annars → “Varning för hög värme”.
            //Skapa en klass Thermometer med attributet Temperature.
            //Lägg till metoden CheckTemperature() som returnerar rätt text enligt logiken.
            //I Main(): Skapa ett objekt av Thermometer, läs in temperaturen via Console.ReadLine(), och skriv ut resultatet från CheckTemperature().
            Thermometer Objekt = new Thermometer();
            Console.WriteLine("Ange Temperatur");
            Objekt.Temperature = double.Parse(Console.ReadLine());
            Console.WriteLine(Objekt.CheckTemperature());

        }
    }
}
