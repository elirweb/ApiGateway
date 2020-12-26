using System;
using System.Collections.Generic;
using System.Net;

namespace PaymentService
{
    public class Service : Interfaces.IOrder
    {
        private readonly Application.AppActions.AplicationService _aplication = new Application.AppActions.AplicationService();
       
        

        public Application.ViewModel.Order ExtortingPayment(Contract.Order payment)
        {
            Application.ViewModel.Order _request = new Application.ViewModel.Order
            {
                Justify = payment.Justify,
                ModifyDate = DateTime.Now,
                Active = 0,
                Code = payment.Code
                
            };

            return Application.Mapper.ToDomainViewModel.Order(_aplication.ExtornoPayment(Application.Mapper.ViewModelToDomain.Order(_request)),"Pagamento extornado com sucesso");

        }

        public Application.ViewModel.Order GenerateInvoice(string note)
            => Application.Mapper.ToDomainViewModel.Order(_aplication.GenerateInvoice(note));
        

        public Application.ViewModel.Order PaymentHistory(string Code)=>

              Application.Mapper.ToDomainViewModel.Order(_aplication.PaymentHistory(Code));
        

        public Application.ViewModel.Order PaymentHistorybyParam(string payment)=>
              Application.Mapper.ToDomainViewModel.Order(_aplication.PaymentHistorybyParam(payment));
        

       
        public Application.ViewModel.Order RecordPayment(Contract.Order payment)
        {
            decimal amount = 0;
            string number = _aplication.GenerateOrderNumber();
            Application.ViewModel.Order product = null;
            var listped = new List<PaymentService.Application.ViewModel.OrderDetails>();
            if (payment.Items.Count > 0)
            {
                foreach (var item in payment.Items)
                {
                    var _itens = new Application.ViewModel.OrderDetails()
                    {
                       
                        Price = item.Price,
                        Product = item.Product,
                        Quantity = item.Quantity,
                        Invoice = number

                    };
                    listped.Add(_itens);
                    amount += Convert.ToDecimal((item.Price / 10) * item.Quantity);
                }

                product = new Application.ViewModel.Order()
                {
                    AmountPayment = amount,
                    CodBranch = payment.CodBranch,
                    Code = payment.Code,
                    Description = payment.Description,
                    Document = payment.Document,
                    EmailAddress = payment.EmailAddress,
                    Hours = DateTime.Now.ToShortTimeString(),
                    IpAddress = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString(),
                    Items = listped,
                    Invoice = number,
                    Active = 1

                };
            }
         
            return Application.Mapper.ToDomainViewModel.Order(_aplication.RegisterPayment(Application.Mapper.ViewModelToDomain.Order(product)),"Produto adicionado com sucesso");
          
        }

        

      
    }
}
