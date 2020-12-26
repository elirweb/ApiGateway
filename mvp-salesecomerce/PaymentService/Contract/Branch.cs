using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PaymentService.Contract
{
    [DataContract]
    public class Branch
    {
        
        [DataMember]
        [Required(ErrorMessage = "Segment is required")]

        public string Segment { get; set; }

        [DataMember]
        [Required(ErrorMessage = "CNPJ or CPF is required")]
        public string Document { get; set; }

      

        public Branch(string _Segment,string _Document)
        {
            this.Segment = _Segment;
            this.Document = _Document;
           
        }

    }
}