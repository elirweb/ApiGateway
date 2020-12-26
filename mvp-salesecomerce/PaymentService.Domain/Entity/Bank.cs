using PaymentService.Domain.ValueObject;

namespace PaymentService.Domain.Entity
{
  
    public class Bank
    {
        public string Name { get; private set; }
        public string Agency { get; private set; }
        public string DigitAgency { get; private set; }

        public string Code { get; private set; }
       
        public string Account { get; private set; }

        public string DigitAccount { get; private set; }

        public string TypeCard { get; private set; } 
        public string CardboardFlags { get; private set; }

        public Bank(string _Name,string _Agency,string _DigitAgency,string _Code,string _Account,string _DigitAccount,string _TypeCard,string _CardboardFlags)
        {
            this.Name = _Name;
            this.Agency = _Agency;
            this.DigitAgency = PaymentService.Util.Cripto.Encriptar(_DigitAgency);
            this.DigitAccount = PaymentService.Util.Cripto.Encriptar(_DigitAccount);
            this.Code = _Code;
            this.Account = PaymentService.Util.Cripto.Encriptar(_Account);
            this.TypeCard = _TypeCard;
            this.CardboardFlags = _CardboardFlags;
        }
        
    }
}