using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e = new Enemy();
            Boss b = new Boss();
            e.talk();
            b.talk();

            //Box_Thinking x = new Box_Thinking(); doesnt work

            


            Console.Read(); 
        }
    }

    public class Enemy
    {
        public virtual void talk()
        {
            Console.WriteLine("yelp");
        }
        //public abstract void Walk()
        //{   does not work    scwiguly

        //}
    }
    public class Boss:Enemy
    {
        public override void talk()
        {
            base.talk();
            Console.WriteLine("\nFoo I am a bigger yelp!");
        }
    }
    //when creating abstract classes and methods the methods only fit into abstract classes.
    // the methods do not have a body. with no code assosiated with them
    public abstract class Box_Thinking
    {
        public Box_Thinking()
        {
        }

        public abstract void Talk();       
    }

    public class OutSide_Thinking
    {

    }

    public class S_Shape
    {
       public S_Shape()
        {

        }
    }
    public class S_Triangle:S_Shape
    {

    }
    public class S_Rectangle:S_Shape
    {

    }
    public class S_Cirle:S_Shape
    {

    }
}
