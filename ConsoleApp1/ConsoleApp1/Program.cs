using ConsoleApp1;

class program
{
    static void Main(string[] args)
    {
        tablice tablice = new tablice();

        tablice.Powitanie();

        int[] tab = tablice.Stworz_tablice();

        Console.Clear();
        tablice.wyswietl_tablice(tab);
    }
}