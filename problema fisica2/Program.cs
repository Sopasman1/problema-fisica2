namespace problema_fisica2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            masa resul = new masa();
            resul.resultado(42,12);
            Console.WriteLine(" =" + resul.dencidad * resul.metros3);
            Console.ReadLine();
        }
    }
}