using System;
using System.Collections.Generic;
using Warehouse.Models;
using Warehouse.Models.Enums;


namespace Warehouse.Data
{
    public static class CustomDB
    {
        public static List<Supplier> GetSuppliers()
        {
            return suppliers;
        }
        
        public static List<PurchaseOrders> GetPurchaseOrders()
        {
            List<PurchaseOrders> result = new List<PurchaseOrders>();

            foreach (var item in officeSupplies)
            {
                result.Add(new PurchaseOrders {
                    Id = item.Id,
                    Type = item.Type
                });
            }
            foreach (var item in computerEquipment)
            {
                result.Add(new PurchaseOrders
                {
                    Id = item.Id,
                    Type = item.Type
                });
            }

            return result;
        }

       static List<Supplier> suppliers = new List<Supplier>
        {
            new Supplier
            {
                Id = 1,
                Name = "Enko",
                Type = (int)SuppliersType.Retail,
                DeliveryTime = 3
            },
            new Supplier
            {
                Id = 2,
                Name = "ORSI",
                Type = (int)SuppliersType.Retail,
                DeliveryTime = 7
            },
            new Supplier
            {
                Id = 3,
                Name = "MTI",
                Type = (int)SuppliersType.Retail,
                DeliveryTime = 2
            },
            new Supplier
            {
                Id = 4,
                Name = "Scholz",
                Type = (int)SuppliersType.Wholesale,
                DeliveryTime = 9
            },
            new Supplier
            {
                Id = 5,
                Name = "Buromax",
                Type = (int)SuppliersType.Wholesale,
                DeliveryTime = 1
            }
        };

       static List<OfficeSupplies> officeSupplies = new List<OfficeSupplies>
        {
            new OfficeSupplies
            {
                Id = 1,
                Type = (int)PurchasesType.OfficeSupplies,
                Color = "Red",
                Kind = "Scissors",
                Price = 15
            },
            new OfficeSupplies
            {
                Id = 2,
                Type = (int)PurchasesType.OfficeSupplies,
                Color = "Blue",
                Kind = "Hole punch",
                Price = 21.83
            },
            new OfficeSupplies
            {
                Id = 3,
                Type = (int)PurchasesType.OfficeSupplies,
                Color = "Black",
                Kind = "Trailer",
                Price = 7.90
            }
        };

        static List<ComputerEquipment> computerEquipment = new List<ComputerEquipment>
        {
            new ComputerEquipment
            {
                Id = 4,
                Type = (int)PurchasesType.ComputerEquipment,
                Kind = "Processor",
                Brand = "Intel",
                Model = "Core i9-9900K",
                Price = 89.50
            },
            new ComputerEquipment
            {
                Id = 5,
                Type = (int)PurchasesType.ComputerEquipment,
                Kind = "SSD",
                Brand = "Kingston",
                Model = "A400",
                Price = 63.55
            },
            new ComputerEquipment
            {
                Id = 6,
                Type = (int)PurchasesType.ComputerEquipment,
                Kind = "Mother Board",
                Brand = "Asus",
                Model = "Z390 Pro",
                Price = 189.50
            }
        };
    }
}
