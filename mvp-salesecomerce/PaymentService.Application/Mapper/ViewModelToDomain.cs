using System;
using System.Collections.Generic;

namespace PaymentService.Application.Mapper
{
    public static class ViewModelToDomain
    {
       
        public static Domain.Entity.Order Order(ViewModel.Order _order)
        {
           
            return
                new Domain.Entity.Order(
                   _order.Document,
                   _order.CodBranch,
                   _order.IpAddress,
                   _order.Hours,
                   _order.AmountPayment,
                   _order.Description,
                   ItemsOrdered(_order.Items),
                   _order.Code,
                   _order.Invoice,
                   _order.EmailAddress,
                   _order.Justify,
                   _order.ModifyDate,
                   _order.Active
                    );
        }

        private static List<Domain.Entity.OrderDetails> ItemsOrdered(List<ViewModel.OrderDetails> model)
        {
            List<Domain.Entity.OrderDetails> _prod = new List<Domain.Entity.OrderDetails>();
           
          
                foreach (var items in model)
                {
                    var p = new Domain.Entity.OrderDetails(

                         items.Number,
                         items.Product,
                         items.Price,
                         items.Quantity,
                   
                        items.Invoice
                    );

                    _prod.Add(p);
                }
           

            return _prod;
        }

        

        public static Domain.Entity.Bank Bank(ViewModel.Bank Bank)
        {
            if (Bank == null) throw new ArgumentException("Não há items");
            return
                new Domain.Entity.Bank(
                    Bank.Name,
                    Bank.Agency,
                    Bank.DigitAgency,
                    Bank.Code,
                    Bank.Account,
                    Bank.DigitAccount,
                    Bank.TypeCard,
                    Bank.CardboardFlags
                    );

        }

       

        

      
    }
}
