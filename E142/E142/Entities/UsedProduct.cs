using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E142.Entities
{
    internal class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactorydate) : base(name, price)
        {
            this.ManufactureDate = manufactorydate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }

    }
}
