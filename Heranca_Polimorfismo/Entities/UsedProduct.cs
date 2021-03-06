﻿using System;
using System.Globalization;

namespace Heranca_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            //                                                                                                       or ManufactureDate.ToString("dd/MM/yyyy")
            return (Name + " (Used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToShortDateString() + ")");
        }
    }
}
