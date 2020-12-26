using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.ViewModel
{
    public class OrderDetails
    {
        public int Number { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

     

        public string Invoice { get; set; }

        
    }
}
