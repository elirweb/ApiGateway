using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PaymentService.Contract
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        [Required(ErrorMessage = "Cep is required")]
        public string Cep { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Telephone is required")]
        public string Telephone { get; set; }
        
        [DataMember]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [DataMember]
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [DataMember]
        [Required(ErrorMessage = "UF is required")]
        public string UF { get; set; }

        [DataMember]
        [Required(ErrorMessage = "DDD is required")]
        public string DDD { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Cellphone is required")]
        public string Cellphone { get; set; }


        public Contact(string _Cep,string _Telephone,string _Address,string _State,string _UF,string _DDD,string _Cellphone)
        {
            this.Cep = _Cep;
            this.Telephone = _Telephone;
            this.Address = _Address;
            this.State = _State;
            this.UF = _UF;
            this.DDD = _DDD;
            this.Cellphone = _Cellphone;
        }

    }
}