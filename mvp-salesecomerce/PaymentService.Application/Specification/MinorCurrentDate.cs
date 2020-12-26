using PaymentService.Domain.Entity;

namespace PaymentService.Application.Specification
{
    public class MinorCurrentDate : Interfaces.ISpecification<Domain.Entity.Order>
    {
        PaymentService.Data.Repositorys.PaymentGeneric _repository = new Data.Repositorys.PaymentGeneric();

        public bool Dissatisfied(Domain.Entity.Order model)
            =>
             _repository.MinorCurrentDate(model) != null?true:false;

        public bool ValidDocument(Order model)
        {
            throw new System.NotImplementedException();
        }
    }
}
