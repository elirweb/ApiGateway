using System.ComponentModel;

namespace PaymentService.Domain.ValueObject
{
    public enum CardType
    {
        [Description("Crédito")]
        Crédito = 0,
        [Description("Debito")]
        Debito = 1,
        [Description("PréPago")]
        PréPago = 2
    }

    public enum CardboardFlags {
        [Description("Visa")]
        Visa = 0,
        [Description("Master Card")]
        MasterCard = 1,
        [Description("Elo")]
        Elo = 2,
        [Description("Cielo")]
        Cielo = 3,

        [Description("Sorocard")]
        Sorocard = 4,

        [Description("American Express")]
        AmericanExpress = 4,
        [Description("HiperCard")]
        HiperCard = 5

    }

    public enum PaymentStatus {
        [Description("Pendente")]
        Pending = 0,
        [Description("Aguardando confirmação de pagamento")]
        AwaitConfirmPayment = 1,
        [Description("Pago")]
        Paid = 2,
        [Description("Cancelado")]
        Cancel = 3,

        [Description("Erro")]
        Error = 4

    }


}
