using PaymentService.Domain.Entity;
using System.Collections.Generic;

namespace PaymentService.Domain.ValueObject
{
    public class Email
    {
       
        public string Endereco { get; private set; }
        public string Assunto { get; private set; }
        public List<OrderDetails> _produtos { get; private set; }

        public Email()
        {
            _produtos = new List<OrderDetails>();
        }
        public Email(string endereco, string assunto, List<OrderDetails> _items)
        {
            if (!string.IsNullOrWhiteSpace(endereco))
            {
                if (IsValid(endereco))
                {
                    Endereco = endereco;
                    Assunto = assunto;
                    _produtos = _items;
                }
            }
        }
        

        public bool IsValid(string end)
        {
            if (end.Contains("@") && end.Contains(".com.br") || end.Contains(".com"))
                return true;
            return false;
        }


    }
}
