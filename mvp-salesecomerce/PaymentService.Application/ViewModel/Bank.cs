using PaymentService.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.ViewModel
{
    public class Bank
    {
        public string Name { get;  set; }
        public string Agency { get;  set; }
        public string DigitAgency { get;  set; }

        public string Code { get;  set; }

        public string Account { get;  set; }

        public string DigitAccount { get;  set; }

        public string TypeCard { get;  set; }

        public string CardboardFlags { get; set; }
    }
}
