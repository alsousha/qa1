using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Flight
    {
        public Customer OrderBy;

        DateTime CreationDate;

        public bool CanBeCancelledBy(Customer customer)
        {
            if (customer.isVIP)
            {
                return true;
            }
            if(customer == OrderBy)
            {
                return true;
            }
            return false;
        }
    }
}
