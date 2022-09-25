using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EnumeracoesEComposicao.Entitties
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

     /*   public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
     */

        public override string ToString()
        {
         StringBuilder sb = new StringBuilder();
          sb.AppendLine(Product.ToString() + ", $" + Price.ToString("f2", CultureInfo.InvariantCulture) + ", quantity: " + Quantity + ", subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));
          return sb.ToString();
        }

    }
}
