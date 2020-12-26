using MongoDB.Bson.Serialization.Attributes;
using PaymentService.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PaymentService.Domain.Entity
{
    public class Order : BaseEntity.Base
    {
        public MongoDB.Bson.ObjectId _idprod { get; set; }
        public string Document { get; private set; }

        public string CodBranch { get; private set; }

        public string Email { get; set; }

        public string IpAddress { get; private set; }
        public string Hours { get; private set; }

        public decimal AmountPayment { get; private set; }
        public int NumberItens { get; private set; }
       
       

        public string Description { get; private set; }
        public List<OrderDetails> Items { get;  private set; }

        public string Code { get;  private set; }

        public string Status { get; private set; }
        public string Protocol { get; private set; }
      
        public string Invoice { get;  set; }

        public ResultValidation List { get;  set; }
        public List<string> Message { get; set; }
        public string Justify { get; private set; }
        public int Active { get; set; }
       

        public Order()
        {
            Items = new List<OrderDetails>();
            Message = new List<string>();
            List = new ResultValidation();
        }
        public Order(string document, string codBranch, string ipAddress, string hours, decimal amountPayment,
              string description, List<OrderDetails> items, string code, [Optional]string invoice,[Optional] string _email,[Optional] string _justify, [Optional] DateTime Modify, [Optional] int _Active)
        {
            Items = new List<OrderDetails>();
            List = new ResultValidation();
           
            Document = PaymentService.Util.Cripto.Encriptar(document);
            CodBranch = codBranch;
            IpAddress = ipAddress;
            Hours = hours;
            AmountPayment = amountPayment;
            Description = description;
            Items.AddRange(items);
            Code = code;
            Invoice = invoice;
            NumberItens = Items.Count;
            Active = _Active;
             Id = Guid.NewGuid();
            Email = _email;
            Created = DateTime.Now;
            ModifyDate = Modify;
            Justify = _justify;
            
        }

    }
        
}
