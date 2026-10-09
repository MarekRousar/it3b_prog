class Dum : Objekt
{
    public int PocetPater { get; set; }
    public int VymeraZahrady { get; set; }

    public Dum(string popis, int cena, int pocetPater, int vymeraZahrady) : base(cena, popis)
    {
        PocetPater = pocetPater;
        VymeraZahrady = vymeraZahrady;
    }
    public void VypisInfo()
    {
        Console.WriteLine($"Dům stojí {Cena} Kč, Má {PocetPater} pater, zahrada má {VymeraZahrady}");
    }
}
