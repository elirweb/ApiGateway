using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PaymentService.Contract
{
    [DataContract]
    public class OrderDetails
    {
        [DataMember]
        [Required(ErrorMessage ="Number is required")]
        public int Number { get; set; }
        [DataMember]
        [Required(ErrorMessage ="Product is required")]
        public string Product { get; set; }
        [DataMember]
        [Required(ErrorMessage ="Price is required")]
        public decimal Price { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Amount is required")]
        public int Quantity { get; set; }

        [DataMember]
        public int DiscountRate { get; set; } 
        [DataMember]
        public decimal Rate { get; set; }

        [DataMember]
        public string Invoice { get; set; }
    }
}