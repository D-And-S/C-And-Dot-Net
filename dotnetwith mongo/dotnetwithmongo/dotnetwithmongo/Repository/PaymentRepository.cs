using dotnetwithmongo.DataContext;
using dotnetwithmongo.Entities;
using dotnetwithmongo.IRepository;
using MongoDB.Driver;

namespace dotnetwithmongo.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IMongoCollection<Payment> _payment;

        public PaymentRepository(IStudentStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _payment = database.GetCollection<Payment>("payment");
        }
        public Payment Create(Payment payment)
        {
            _payment.InsertOne(payment);
            return payment;
        }

        public List<Payment> GetAllPayment()
        {
            return _payment.Find(s=> true).ToList();
        }

        public Payment GetPaymentById(string id)
        {
            return _payment.Find(s => s.Id == id).FirstOrDefault();
        }
    }
}
