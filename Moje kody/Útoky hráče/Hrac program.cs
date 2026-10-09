class Hrac
{
    public void Utok()
    {
        Console.WriteLine("Bojovník útočí.");
    }
    
    public void Utok(int sila)
    {
        Console.WriteLine($"Bojovník útočí silou {sila}.");
    }
    public void Utok(string zbran)
    {
        Console.WriteLine($"Bojovník útočí pomocí {zbran}.");
    }

    public void Utok(string zbran, int sila)
    {
        Console.WriteLine($"Bojovník útočí pomocí {zbran} silou {sila}.");
    }
}
