using PaymentService.Domain.Entity;
using System;
using System.Collections.Generic;

namespace PaymentService.Data.Interfaces
{
    public interface IOrder
    {

        Order RecordPayment(Order payment);
        Order PaymentHistorybyParam(string payment);
        Order PaymentHistory(string Code);
        Order GenerateInvoice(string note);
        
        Order MinorCurrentDate(Order payment);
       
        

    }
}
