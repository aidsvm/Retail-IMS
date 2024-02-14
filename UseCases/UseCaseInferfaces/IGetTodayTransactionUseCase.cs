using CoreBusiness;

namespace UseCases
{
    public interface IGetTodayTransactionUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}