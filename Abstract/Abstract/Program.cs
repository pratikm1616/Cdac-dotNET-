namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABSTRACT ");
            Derived d=new Derived();
         //   d.derived();
            //d.Method();
            //d.Method2();
        }
    }

    public abstract class Abst
    {

        public Abst() {
            Console.WriteLine("Const in abstract class");
        }
        //public void Method()
        //{
        //    Console.WriteLine("Abstract method in abstract class");
        //}

        //public void Method2()
        //{
        //    Console.WriteLine("Method 2 in abst class");
        //}
       
    }

    public class Derived : Abst { 
        public  Derived()
        {
            Console.WriteLine("Method in derived class");
        }
    }
}
