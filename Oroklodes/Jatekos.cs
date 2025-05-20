namespace Oroklodes;

internal class Jatekos : Karakter
{
    public int Tapasztalat { get; set; }
    
    public Jatekos(string nev, int elet, int tapasztalat, int sebzes) : base(nev, elet, sebzes)
    {
        Tapasztalat = tapasztalat;
    }
    
    public override void Tamad()
    {
        Console.WriteLine($"{Nev} karddal támad! Tapasztalat: {Tapasztalat} xp, Sebzés: {Sebzes}");
    }
}