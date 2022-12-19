using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryOops.LibraryPolymorphism;

namespace LibraryOops
{
    class LibraryEncapsulation
    {
        private String customerName;
        private int Customercode;

        public String Name     //Name is property
        {

            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }

        }
        public int customerid
        {

            get
            {
                return Customercode;
            }

            set
            {
                Customercode = value;
            }

        }
    }
}
