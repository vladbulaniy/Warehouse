namespace Warehouse.Models
{
    public class OfficeSupplies: PurchaseOrders
    {
        public string Kind { get; set; }
        public string Color { get; set; }
    }
}
