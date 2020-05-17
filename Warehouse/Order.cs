using System;
using System.Collections.Generic;
using System.Linq;
using Warehouse.Data;
using Warehouse.Interfaces;
using Warehouse.Models;
using Warehouse.Models.Enums;

namespace Warehouse
{
    public class Order : IOrder
    {
        public List<SuppliersOrders> suppliersOrders { get; set; }

        public Order()
        {
            suppliersOrders = new List<SuppliersOrders>();
        }

        public string IssueOrder(int supplierId, int ProductId, int ProductCount)
        {            
            var products = CustomDB.GetPurchaseOrders();
            var suppliers = CustomDB.GetSuppliers();

            Supplier supplier = suppliers.Find(s => s.Id == supplierId);

            var product = products.Find(p => p.Id == ProductId);

            SuppliersOrders newSuppliersOrders = new SuppliersOrders
            {
                ProductId = product.Id,
                SupplierId = supplierId,
                ProductCount = ProductCount
            };
            suppliersOrders.Add(newSuppliersOrders);

            string productType = Enum.GetName(typeof(PurchasesType), product.Type);
            string supplierType = Enum.GetName(typeof(SuppliersType), supplier.Type);
            return String.Format("Issued Purchase Order for {0} to supplier {1}", productType, supplierType);
        }

        public string ProcessOrder(int ProductId, int ProductCount)
        {
            var supplier = suppliersOrders.FirstOrDefault(p => p.ProductId == ProductId && p.ProductCount == ProductCount);

            if(supplier == null)
            {
                return "Cant find any created orders for this params";
            }

            int deliveryTime = GetDeliveryTime(supplier.SupplierId);

            return String.Format("Message from Supplier {0}: Received order for {1} quantity of Product {2}. The order will be processed in {3} days", supplier.SupplierId, ProductCount, ProductId, deliveryTime);
        }

        private int GetDeliveryTime(int SupplierId)
        {
            var suppliers = CustomDB.GetSuppliers();

            return suppliers.Find(s => s.Id == SupplierId).DeliveryTime;
        }
    }
}
