using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOops
{
    class LibraryInheritance
    {

        string name = "Central Library";

        class Library2Inheritance : LibraryInheritance
        {
            string address = "Banglore";


            static void Main(string[] args)
            {

                Library2Inheritance hi = new Library2Inheritance();


                Console.WriteLine(hi.name);
                Console.WriteLine(hi.address);
                Console.ReadLine();

                LibraryDetail bankDetail = new LibraryDetail();  // Create a HospitalDetail object
                bankDetail.Library();
                bankDetail.LibraryID();
                Console.ReadLine();

                LibraryPolymorphism libraryPolymerphis = new LibraryPolymorphism();
                LibraryPolymorphism libraryReview = new LibraryReview();
                LibraryPolymorphism libraryCharges = new LibraryCharges();
                libraryPolymerphis.Library();
                libraryReview.Library();
                libraryCharges.Library();

                Console.ReadLine();


                LibraryMethodOverload libraryMethodOverload = new LibraryMethodOverload();
                libraryMethodOverload.LibraryData("Subha Lakshmi L");
                libraryMethodOverload.LibraryData("Subha Lakshmi L",
                                                  202017);
                Console.ReadLine();


                LibraryEncapsulation libraryEncapsulatio = new LibraryEncapsulation();
                libraryEncapsulatio.Name = "Subha Lakshmi L";
                libraryEncapsulatio.customerid = 202017;
                Console.WriteLine("Name: " + libraryEncapsulatio.Name);
                Console.WriteLine("ID: " + libraryEncapsulatio.customerid);
                Console.ReadLine();
            }
        }
    }
}

