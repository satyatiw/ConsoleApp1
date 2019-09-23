using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{ //Encapsulation
    public class Program
    {
        public string firstName;
        public string lastName;

        public void GetFullName()
        {
            Console.WriteLine("ur full name is {0} {1}.", firstName, lastName);
        }
        public void Walk()
        {
            Console.WriteLine("I can Walk.");

        }
        public void Talk()
        {
            Console.WriteLine("I can Talk.");
        }
        public virtual void Sing()
        {
            Console.WriteLine("I can Sing.");
        }
        public void Sleep()
        {
            Console.WriteLine("I sleep min. 8 hours");
        }
        //Overloading
        public void Sleep(int i)
        {
            Console.WriteLine("Min. hours i Sleep :"+ i );
        }
    }
    //Inheritence
    class SuperMan : Program
    {
        public void Fly()
        {
            Console.WriteLine("I can ALSO FLY");
        }
        //Overriding
        public override void Sing()
        {
            Console.WriteLine("sry, I can't sing");
        }

        //Method Hiding
        public new void Walk()
        {
            Console.WriteLine("I am a Flash.");
        }

        static void Main(string[] args)
        {
            Program p = new Program
            {
                firstName = "Satyam",
                lastName = "Tiwari"
            };

            //Abstraction
            p.GetFullName();
            p.Walk();
            p.Talk();
            p.Sing();
           
            p.Sleep(12);

            Console.ReadLine();

            SuperMan sm = new SuperMan
            {
                firstName = "satya",
                lastName = "Tiwari"
            };
            sm.GetFullName();
            sm.Fly();
            sm.Sing();
            sm.Walk();
            Console.ReadLine();


        }
    }


}



