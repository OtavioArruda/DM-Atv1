namespace Exe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = "maca,banana,limao,abacaxi,banana";

            List<string> frutas = new List<string>();

            frutas = entrada.Split(',').Select(x => char.ToUpper(x[0]) + x.Substring(1)).ToList();

            frutas.ForEach(x => Console.WriteLine(x));
        }
    }
}