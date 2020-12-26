using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PaymentService.Application.ViewModel
{
    public class Company
    {
        public string TraddingName { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public Branch Branch { get; set; }

        public Contact Contact { get; set; }

        public string MatrixDocument { get; set; }
     
        public List<string> Message { get; set; }
        public string Status { get; set; }
        public Bank Bank { get; set; }
        public Company()
        {
            Bank = new Bank();
            Message = new List<string>();
            Branch = new Branch();
            Contact = new Contact();
        }

       

    }
}
