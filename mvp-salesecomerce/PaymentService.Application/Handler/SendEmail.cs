using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Handler
{
    public class SendEmail : Domain.Interfaces.ISend
    {
        public async Task SendAsync(Domain.ValueObject.Email email)
        {
           
            if (!string.IsNullOrWhiteSpace(email.Endereco))
            {
                StringBuilder _body = new StringBuilder();
                var _invoice = string.Empty;
                decimal Amount = 0;
                _body.Append("Produtos :");
                foreach (var p in email._produtos)
                {
                    _body.Append(p.Product + "<br />");
                    _body.Append("Preço : " + string.Format("{0:n2}", p.Price) + "<br />");
                    _body.Append("Quantidade :" + p.Quantity + "<br />");
                    _invoice = p.Invoice;
                    Amount += (p.Price / 10) * p.Quantity;
                }
                _body.Append("Total: " + string.Format("{0:n2}", Amount) + "<br />");
                _body.Append("Código do Produto: " + _invoice);

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                
                using (var client = new SmtpClient())
                {
                    client.Port = 587;
                    client.Host = "smtp.gmail.com"; //elir
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.Credentials = new NetworkCredential("elirweb@gmail.com", "738529hs");
                   
                    var mm = new MailMessage("elirweb@gmail.com", email.Endereco, email.Assunto, PaymentService.Util.Constant.BodyEmail(_body).ToString())
                    {
                        Priority = MailPriority.Normal,
                        IsBodyHtml = true,
                        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    };
                    client.Send(mm);
                    AlternateView av1 = AlternateView.CreateAlternateViewFromString(_body.ToString(), null, MediaTypeNames.Text.Html);
                    mm.AlternateViews.Add(av1);
                    await Task.FromResult(0);
                }
            }
        }
    }
}