class Program
{
    static void Main()
    {
        Hrac hrac = new Hrac();

        hrac.Utok();
        hrac.Utok(50);
        hrac.Utok("meče");
        hrac.Utok("sekery", 100);
    }
}
