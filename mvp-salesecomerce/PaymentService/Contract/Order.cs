using PaymentService.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace PaymentService.Contract
{
    [DataContract]
    public class Order
    {
      
        [DataMember]
        [Required(ErrorMessage ="Cnpj or CPF is required")]
        public string Document { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public string CodBranch { get; set; }
        

       
        public string IpAddress { get; set; }
       
        public string Hours { get; set; }

       
        public decimal AmountPayment { get; set; }
        [DataMember]
        [Required(ErrorMessage = "NumberItens is required ")]
        public int NumberItens { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }
        
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public List<OrderDetails> Items { get; set; }
        
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Invoice { get; set; }

       
        public ResultValidation List { get; set; }
        [DataMember]
        public string Justify { get; set; }

       

        public Order(string document,string codBranch,string ipAddress,string hours,decimal amountPayment,
            int numberItens, string email, string description, OrderDetails items,Guid code,[Optional]string invoice)
        {
            Items = new List<OrderDetails>();
            Document = document;
            CodBranch = codBranch;
            IpAddress = ipAddress;
            Hours = hours;
            AmountPayment = amountPayment;
            NumberItens = numberItens;
            EmailAddress = email;
            Description = description;
            Items.Add(items);
            Code = Guid.NewGuid().ToString();
            Invoice =invoice;
           

        }



    }
}