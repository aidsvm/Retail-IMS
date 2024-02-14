namespace UseCases
{
    public interface IRecordTransactionsUseCase
    {
        void Execute(string cashierName, int productId, int quantity);
    }
}