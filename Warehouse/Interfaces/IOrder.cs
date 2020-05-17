namespace Warehouse.Interfaces
{
    public interface IOrder
    {
        string IssueOrder(int supplierName, int ProductId, int ProductCount);
        string ProcessOrder(int ProductId, int ProductCount);        
    }
}
