namespace AutoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Autoprop obj = new Autoprop();
            obj.Props="hyfyhr";
            Console.WriteLine(obj.Props);
        }
    }

    public class Autoprop
    {
        public string Props { get; set; }
    }
}
