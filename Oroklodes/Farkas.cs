namespace Oroklodes;

internal class Farkas : Karakter
{
    public bool Szeliditett { get; set; }
    
    public Farkas(string nev, int elet, bool szeliditett, int sebzes) : base(nev, elet, sebzes)
    {
        Szeliditett = szeliditett;
    }
    
    public override void Tamad()
    {
        if (Szeliditett)
        {
            Console.WriteLine($"{Nev} segít a játékosnak támadni! (Sebzés: {Sebzes})");
        }
        else
        {
            Console.WriteLine($"{Nev} harap! (Sebzés: {Sebzes})");
        }
    }
}