using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLib
{
    public sealed class Singleton5 // The key word "sealed" here prevents inheritance.
    {
        public void doSomeWork()
        {
            Console.WriteLine("Singleton5 is working.");
        }

        private Singleton5() // private prevents instantiation via constructor directly outside this class.
        {
            // We can do some init work here.
            // For example, load config etc.

        }
        public static Singleton5 Instance // define a property to get the Singleton instance.
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested // By default, it's private.
        {
            static Nested()
            {
                // We can also do some one time init work here;

            }

            internal static readonly Singleton5 instance = new Singleton5();
        }

    }
}
