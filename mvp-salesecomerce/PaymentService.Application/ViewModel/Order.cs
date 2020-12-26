using PaymentService.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.ViewModel
{
    public class Order
    {
        public string Document { get;  set; }

        public string CodBranch { get;  set; }


        public string IpAddress { get;  set; }
        public string Hours { get;  set; }

        public decimal AmountPayment { get;  set; }
        public int NumberItens { get;  set; }

        public string EmailAddress { get;  set; }

        public string Description { get;  set; }
        public List<OrderDetails> Items { get;   set; }
  
        public string Code { get;  set; }

        public string Status { get;  set; }

        public List<string> Message { get;  set; }

        public string Invoice { get; set; }
        public ResultValidation List { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Justify { get; set; }
        public int Active { get; set; }

        public Order()
        {
            Items = new List<OrderDetails>();
            Message = new List<string>();
        }
    }
}
