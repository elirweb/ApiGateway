using MongoDB.Driver;
using PaymentService.Domain.Entity;
using System;
using System.Configuration;

namespace PaymentService.Data.Config
{
    public class Connection : IDisposable
    {


         public IMongoDatabase _database { get; }
        MongoClient mongoClient;

        public Connection()
        {
            try
            {
                MongoClientSettings config = MongoClientSettings.FromUrl(new MongoUrl(ConfigurationManager.AppSettings["enderecomongodb"]));
                 mongoClient = new MongoClient(config);
                _database = mongoClient.GetDatabase("payment");
            }
            catch (MongoException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception g)
            {

                throw new Exception(g.Message);
            }
        }

        public IMongoCollection<Order> Order
        {
            get
            {
                return _database.GetCollection<Order>("Order");
            }
        }

       


        public void Dispose() { mongoClient = null;GC.SuppressFinalize(this._database); }
      
    }
}
