using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOops
{
    // Abstract class
    abstract class Libraryname
    {
        // Abstract method (does not have a body)
        public abstract void Library();
        // Regular method
        public void LibraryID()
        {
            Console.WriteLine("120000083");
        }
    }

    // Derived class (inherit from HospitalName )
    class LibraryDetail : Libraryname
    {
        public override void Library()
        {
            // The body of HosName() is provided here
            Console.WriteLine("Hospital name is SBI");
        }


    }


}
