namespace PaymentService.Application.Interfaces
{
    public interface ISpecification<T>
    {
        bool Dissatisfied(T model);

        bool ValidDocument(T model);
    }
}
