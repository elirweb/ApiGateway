using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PaymentService.Domain.Entity
{
    public class ResultValidation
    {
        public List<ValidationError> Error { get;   set; }

        public ResultValidation()
        {
            this.Error = new List<ValidationError>();
        }
    }

    [DataContract]
    public class ValidationError
    {
        public string Message { get; set; }
        public ValidationError(string message)
        {
            this.Message = message;
        }
        
         

    }
}
