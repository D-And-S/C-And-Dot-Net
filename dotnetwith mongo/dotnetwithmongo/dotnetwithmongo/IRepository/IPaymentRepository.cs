using dotnetwithmongo.Entities;

namespace dotnetwithmongo.IRepository
{
    public interface IPaymentRepository
    {
        List<Payment> GetAllPayment();
        Payment Create(Payment student);
        Payment GetPaymentById(string id);
    }
}
