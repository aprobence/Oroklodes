namespace Oroklodes;

class Program
{
    static void Main(string[] args)
    {
        List<Karakter> karakterek = new List<Karakter>();
        
        karakterek.Add(new Jatekos("Steve", 20, 5, 5));
        karakterek.Add(new Zombi("Zombi", 10, 2));
        karakterek.Add(new Csontvaz("Csontváz", 15, 3));
        karakterek.Add(new Farkas("Farkas", 8, true, 1));
        karakterek.Add(new Farkas("Vadon Farkas", 8, false, 2));

        foreach (Karakter karakter in karakterek) 
        { 
            Console.WriteLine($"Név: {karakter.Nev}, Élet: {karakter.Elet}"); 
            karakter.Tamad();
        }
        
        Console.WriteLine("Kezdődik a harc!");
        Jatekos jatekos = karakterek[0] as Jatekos;
        Karakter ellenfel = karakterek[1];
        Harc(jatekos, ellenfel);
        
        static void Harc(Jatekos jatekos, Karakter ellenfel)
        {
            Console.WriteLine($"{jatekos.Nev} harcol {ellenfel.Nev}-el!");
        
            while (jatekos.Elet > 0 && ellenfel.Elet > 0)
            {
                jatekos.Tamad();
                ellenfel.Elet -= jatekos.Sebzes;
                Console.WriteLine($"{ellenfel.Nev} élete: {ellenfel.Elet}");
            
                if (ellenfel.Elet <= 0)
                {
                    Console.WriteLine($"{ellenfel.Nev} legyőzve!");
                    break;
                }
            
                ellenfel.Tamad();
                jatekos.Elet -= ellenfel.Sebzes;
                Console.WriteLine($"{jatekos.Nev} élete: {jatekos.Elet}");
            
                if (jatekos.Elet <= 0)
                {
                    Console.WriteLine($"{jatekos.Nev} legyőzve!");
                    break;
                }
            }
        }
    }
}