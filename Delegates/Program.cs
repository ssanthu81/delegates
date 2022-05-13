class Program
{
    public void Addnum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static string hello (string name ){

        return "helloo" + name;

}

    static void Main(string[] args)
    {
        Program p = new Program();
        p.Addnum(25 , 24);
        string st = Program.hello("shiva");
        Console.WriteLine(st);

        Console.ReadLine();

    }
}


