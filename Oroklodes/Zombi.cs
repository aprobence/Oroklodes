namespace Oroklodes;

internal class Zombi : Karakter
{
    public Zombi(string nev, int elet, int sebzes) : base(nev, elet, sebzes)
    {
        // Zombi konstruktor
    }
    
    public override void Tamad()
    {
        Console.WriteLine($"{Nev} hörögve támad! (Sebzés: {Sebzes})");
    }
    
}