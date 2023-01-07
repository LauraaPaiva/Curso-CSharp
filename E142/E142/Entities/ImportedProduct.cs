using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace E142.Entities
{
    internal class ImportedProduct : Product
    {

        public Double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            this.CustomFee = customFee;
        }

        public Double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomFee + " )";
        }
    }
}
