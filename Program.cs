using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q_2
{
    public class Shape
    {
        //private void WhoamI()[ERROR]
        //( Parent Class should contain virtual method for the child class to override and access should be public )

        public virtual void WhoamI()
        {
            Console.WriteLine("I m Shape");
        }

    }

    //class Triangle : public Shape[ERROR]
    //( While inheriting parent class there is no need to mention access specifier ) 

    class Triangle : Shape
    {

        //public virtual void WhoamI()[ERROR]
        //( Child class should override the parent class method )

        public override void  WhoamI()
         {
              Console.WriteLine("I m Triangle");
         }
        
    }

    //class Circle  : public Shape[ERROR]
    //( While inheriting parent class there is no need to mention access specifier ) 

    public class Circle : Shape
    {   
        //void WhoamI()[ERROR]
        //( Child class method should contain override keyword in order to override the parent class method )
         
        public override void WhoamI()
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
