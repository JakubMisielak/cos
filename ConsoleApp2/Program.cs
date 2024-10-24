class Klasa
{
    static void Main(string[] args)
    {
        int a, b;
    liczba1:
        Console.WriteLine("podaj 1 liczbe :");
        bool mlem = int.TryParse(Console.ReadLine(), out a);

        Console.WriteLine("podaj 2 liczbe do powrownania: ");
        bool mlen = int.TryParse(Console.ReadLine(), out b);
        while (mlem == false || mlen == false) 
        {
            Console.WriteLine("podales liczbe nie calkowita");
            goto liczba1;
             
        }
        if (a == b)
        {
            Console.WriteLine("liczba jest rowna");
        }
        else if (a > b)
        {
            Console.WriteLine($"liczba {a} jest wieksza");
        }
        else
        {
            Console.WriteLine($"liczba {b} jest wieksza");
        }
    }
}
