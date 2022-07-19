using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppValueObjectPOC
{
    public class Order
    {
        public int OrderId { get; private set; }

        public Address Address { get; set; }

        //public string Street { get; set; }
        //public string City { get; set; }
        //public string State { get; set; }
        //public string Country { get; set; }
        //public string ZipCode { get; set; }
    }
}
