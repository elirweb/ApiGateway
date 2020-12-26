using PaymentService.Domain.Entity;

namespace PaymentService.Application.AppActions
{
    public class AplicationService
    {
        private readonly Data.Repositorys.PaymentGeneric _repository = new Data.Repositorys.PaymentGeneric();
        private Domain.Entity.Order _order = new Order();
        public Domain.Entity.Order RegisterPayment(Domain.Entity.Order model)
        {
            return _repository.RecordPayment(model);
        }

        public Domain.Entity.Order GenerateInvoice(string note) =>
            _repository.GenerateInvoice(note);

        public Domain.Entity.Order PaymentHistory(string Code)
            => _repository.PaymentHistory(Code);

        public Domain.Entity.Order PaymentHistorybyParam(string parame) =>
             _repository.PaymentHistorybyParam(parame);

       

        public Order ExtornoPayment(Order request)
        {
            return _order;
        }

        public string GenerateOrderNumber()
           => _repository.GenerateOrderNumber();
        
    }
}
