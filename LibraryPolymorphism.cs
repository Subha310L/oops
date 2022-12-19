using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOops
{
    class LibraryPolymorphism
    {
        public virtual void Library()
        {
            Console.WriteLine("This is central Library");
        }
    }
    class LibraryReview : LibraryPolymorphism
    {
        public override void Library()
        {
            Console.WriteLine("Read books for free and Rent Books ");
        }
    }
    class LibraryCharges : LibraryPolymorphism
    {
        public override void Library()
        {
            Console.WriteLine("2 Books Plan Rs 290 / Monthly Registration Rs 250 Refundable Deposit Rs 800 3 Months Subscription ");
        }
    }
}
