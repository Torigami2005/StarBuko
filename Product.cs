using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuko
{
    internal class Product
    {
        public string prodName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal itemPrice { get; set; }
        public decimal totalPrice 
        { 
            get { return ItemQuantity * itemPrice; }
        }

        
    }
}
