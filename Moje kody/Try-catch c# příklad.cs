class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Zadej cenu skupinového lístku: ");
            int cena = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Zadej počet osob: ");
            int osoby = int.Parse(Console.ReadLine());

            int jedenlistek = cena / osoby;
            Console.WriteLine($"Cena pro jednoho: {jedenlistek}");
        }
        catch (FormatException) {
            Console.WriteLine("Musíš zadat číslo!");
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Nulou nelze dělit!");
        }
    }
}
