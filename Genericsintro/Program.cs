namespace Genericsintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

        }
    }
}