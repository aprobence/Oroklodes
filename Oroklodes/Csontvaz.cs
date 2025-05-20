namespace Oroklodes;

internal class Csontvaz : Karakter
{
    public Csontvaz(string nev, int elet, int sebzes) : base(nev, elet, sebzes)
    {
        // Csontvaz konstruktor
    }
    
    public override void Tamad()
    {
        Console.WriteLine($"{Nev} íjjal támad! (Sebzés: {Sebzes})");
    }
}