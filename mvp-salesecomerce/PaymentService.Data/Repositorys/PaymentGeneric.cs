using MongoDB.Driver;
using PaymentService.Data.Interfaces;
using PaymentService.Domain.Entity;
using System;
using System.Linq;

namespace PaymentService.Data.Repositorys
{

    public class PaymentGeneric : IOrder
    {
        Config.Connection db = new Config.Connection();
        public Order GenerateInvoice(string note)
        {

            return db.Order.Find(x => x.Invoice.Equals(note)).FirstOrDefault();
        }

        public Order PaymentHistory(string Code)
        {
            IMongoCollection<Order> collection = db.Order;
            return collection.Find(x => x.Code == Code).FirstOrDefault();
        }

        public Order PaymentHistorybyParam(string payment)
        {
            return db.Order.Find(x => x.Invoice.Equals(payment)).FirstOrDefault();
        }

        public Order RecordPayment(Order PAYMENT)
        {
            if (PAYMENT.Items == null)
                throw new ArgumentException("Não há produto");
        
            IMongoCollection<Order> collection = db.Order;
            collection.InsertOne(PAYMENT);
            return collection.Find(x => x.Code == PAYMENT.Code).First();
        }

        public string GenerateOrderNumber()
        {
            string number = PaymentService.Util.ValuePayment.GenerateOrderNumber(6);
            IMongoCollection<Order> collection = db.Order;
            if (collection.Find(x => x.Invoice.Equals(number)).CountDocuments() > 0)
                return GenerateOrderNumber();
            return number;
        }

       

       

        

        public Order MinorCurrentDate(Order payment)
        {
            IMongoCollection<Order> collection = db.Order;
            var filter = Builders<Order>.Filter.Eq("Code", payment.Code);
            var update = Builders<Order>.Update.Set("Justify", payment.Justify).
                Set("Active", payment.Active).Set("ModifyDate", payment.ModifyDate).Set("Protocol",payment.Protocol);

             collection.UpdateMany(filter, update);
            return collection.Find(x => x.Code.Equals(payment.Code)).SingleOrDefault();



        }

        

        public void Dispose() =>
            db?.Dispose();
        
    }

}
