using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PaymentService.Contract
{
    [DataContract]
    public class Company
    {
       
        [DataMember]
        [Required(ErrorMessage = "TraddingName is required")]
        public string TraddingName { get; set; } 

        [DataMember]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [DataMember]
        public Branch Branch { get; set; }
        [DataMember]
        public Contact Contact { get; set; }

        [DataMember]
        [Required(ErrorMessage = "CNPJ or CPF is required")]
        public string MatrixDocument { get; set; }

       public List<string> Message { get; set; }


        [DataMember]
        public Bank Bank { get; set; }

        [DataMember]
        [Required(ErrorMessage ="Logo is required")]
        public string Logo { get; set; }
        
        public Company(string _TraddingName,string _Name,Branch _Branch, Contact _Contact,string _MatrixDocument, Bank _Bank,string _Logo)
        {
            this.TraddingName = _TraddingName;
            this.Name = _Name;
            this.Branch = _Branch;
            this.Contact = _Contact;
            this.MatrixDocument = _MatrixDocument;
            this.Bank = _Bank;
            this.Logo = _Logo;
        }

        public Company()
        {
            Message = new List<string>();
        }


    }
}