using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PaymentService.Contract
{
    [DataContract]
    public class Bank
    {
        [DataMember]
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Agency is required")]
        public string Agency { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Digit Agency is required")]
        public string DigitAgency { get; set; }

        [DataMember]
        [Required(ErrorMessage ="Code is required")]
        public string Code { get; set; }
       
        [DataMember]
        [Required(ErrorMessage = "Account is required")]
        public string Account { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Digit Account is required")]
        public string DigitAccount { get; set; }

        [DataMember]
        [Required(ErrorMessage = "TypeCard is required")]
        public Domain.ValueObject.CardType TypeCard { get; set; }

        [DataMember]
        [Required(ErrorMessage = "CardboardFlags is required")]
        public Domain.ValueObject.CardboardFlags CardboardFlags { get; set; }


        public Bank(string _Name,string _Agency,string _DigitAgency,string _Code,string _Account,string _DigitAccount, Domain.ValueObject.CardType _TypeCard, Domain.ValueObject.CardboardFlags _cardboardFlags)
        {
            this.Name = _Name;
            this.Agency = _Agency;
            this.DigitAgency = _DigitAgency;
            this.Code = _Code;
            this.Account = _Account;
            this.DigitAccount = _DigitAccount;
            this.TypeCard = _TypeCard;
            this.CardboardFlags = _cardboardFlags;
        }
    }
}