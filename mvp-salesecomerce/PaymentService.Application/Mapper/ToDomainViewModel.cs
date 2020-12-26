using PaymentService.Application.Handler;
using PaymentService.Application.ViewModel;

namespace PaymentService.Application.Mapper
{
    public static class ToDomainViewModel
    {
        

        public static ViewModel.Order Order(Domain.Entity.Order _order,string msg) {
            Order _request = new Order();
            if (_order.List.Error.Count > 0)
            {
                _order.List.Error.ForEach(c => _request.Message.Add(c.Message));
                _request.Status = "Erro";
            }
            else
            {
                _request.Message.Add(msg);
                _request.Invoice = _order.Invoice;
                SendEmail _send = new SendEmail();
                var Email = _send.SendAsync(new Domain.ValueObject.Email(_order.Email,"By Request",_order.Items));
         
                _request.Status = "ok";
            }
            return _request;
        }

        public static ViewModel.Order Order(Domain.Entity.Order _order) {
            ViewModel.Order _produto = new ViewModel.Order
            {
                Description = _order.Description,
                Active = _order.Active,
                Document = PaymentService.Util.Decript.Descript(_order.Document),
                AmountPayment = _order.AmountPayment,
                CodBranch = _order.CodBranch,
                Code = _order.Code,
                NumberItens = _order.NumberItens,
                Invoice = _order.Invoice,
                Status = _order.Status,
                EmailAddress = _order.Email
                
            };
            foreach (var prod in _order.Items) {
                _produto.Items.Add(new OrderDetails() { Product = prod.Product, Invoice = prod.Invoice, Number = prod.Number, Price = prod.Price, Quantity = prod.Quantity  });
            }

            return _produto;


        }



    }
}
