using System.Threading.Tasks;

namespace PaymentService.Domain.Interfaces
{
    public interface ISend
    {
        Task SendAsync(Domain.ValueObject.Email email);
    }
}