using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q_2
{
    public class Shape
    {
       public virtual void WhoamI()
        {
            Console.WriteLine("I m Shape");
        }
    }
     class Triangle : Shape
     {
        public override void WhoamI()
        {
            Console.WriteLine("I m Triangle");
        }
     }
     public class Circle : Shape
     {
        //void WhoamI()[ERROR]
        //( By putting new keyword, the parent class method is not overridden )

        public new void WhoamI()
        {
            Console.WriteLine("I m Circle");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Triangle();
            s.WhoamI();

            s = new Circle();
            s.WhoamI();

            Console.ReadKey();
        }
    }
}
