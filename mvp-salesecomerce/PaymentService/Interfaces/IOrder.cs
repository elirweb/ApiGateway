using PaymentService.Contract;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace PaymentService.Interfaces
{

    [ServiceContract]
    public interface IOrder
    {
        [WebInvoke(Method = "POST",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json,
               BodyStyle = WebMessageBodyStyle.Bare,
                UriTemplate = "RegistrarNovoPedido")]
        [OperationContract]

        Application.ViewModel.Order RecordPayment(Order payment);

        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped,
           UriTemplate = "/HistoricoPorPedido/{payment}")]
        [OperationContract]
        Application.ViewModel.Order PaymentHistorybyParam(string payment);

        [WebInvoke(Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
                UriTemplate = "HistoricoPedido/{Code}")]
        Application.ViewModel.Order PaymentHistory(string Code);

        [WebInvoke(Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
                UriTemplate = "NotaFiscal/{note}")]
        [OperationContract]
        Application.ViewModel.Order GenerateInvoice(string note);

        

        [WebInvoke(Method = "POST",
               ResponseFormat = WebMessageFormat.Json,
               RequestFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "ExtornarPagamento")]
        [OperationContract]
        Application.ViewModel.Order ExtortingPayment(Order payment);


    }

}
