using System;

namespace PaymentService.Domain.Entity
{
    public class OrderDetails
    {
        public int Number { get; private set; }
        public string Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

       

        public string Invoice { get;  set; }

        
        public OrderDetails()
        {

        }
        public OrderDetails(int _Number,string _Product,decimal _Price,int _Quantity,string _Invoice)
        {
            this.Number = _Number;
            this.Product = _Product;
            this.Price = _Price;
            this.Quantity = _Quantity;
        
            this.Invoice = _Invoice;



        }
    }
}
