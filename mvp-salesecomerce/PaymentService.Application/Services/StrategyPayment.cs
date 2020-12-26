namespace PaymentService.Application.Services
{
    public abstract class StrategyPayment<T> where T: class
    {
        public virtual T Validate( T model) {
            object h = model;
            T objeto = (T)h;
            return objeto;
        }

    }

    public class Context<T> where T:class {
        private readonly StrategyPayment<T> _strategy;

        public Context(StrategyPayment<T> model)
        {
            this._strategy = model;
        }

        public T Validate(T model) {
            return this._strategy.Validate(model);
        }
    }
}
