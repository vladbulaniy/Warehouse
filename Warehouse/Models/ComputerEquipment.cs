namespace Warehouse.Models
{
    public class ComputerEquipment: PurchaseOrders
    {
        public string Kind { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
