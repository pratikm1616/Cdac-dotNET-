namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEALED");
            Car obj=new Car();
            obj.company();
            obj.model();    
            obj.color();
        }
    }

    public class Vehical
    {
       // string cname;
     public void company()
        {
            Console.WriteLine("Name of Company : Toyota");
        }
        virtual public void model()
        {
            Console.WriteLine("Name of Model : LC300");
        }
    } 

    public class Car:Vehical
    {
        sealed override public void model()
        {
            Console.WriteLine("Name of Model : LC300");
        }

        public void color()
        {
            Console.WriteLine("Red");
        }
        public void build()
        {
            Console.WriteLine("2025 latest sahara edition");
        }
    }

    public class Brand : Car
    {
        override public void model()
        {
            Console.WriteLine("Name of Model : LC300");
        }
    }
}
