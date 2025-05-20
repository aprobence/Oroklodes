namespace Oroklodes;

internal class Karakter
{
    public string Nev { get; set; }
    public int Elet { get; set; }
    public int Sebzes { get; set; }
    
    public Karakter(string nev, int elet, int sebzes)
    {
        Nev = nev;
        Elet = elet;
        Sebzes = sebzes;
    }
    
    public virtual void Tamad()
    {
        Console.WriteLine($"{Nev} támad! (Sebzés: {Sebzes})");
    }
}