using Ex01.Entities.Enums;
using System.Text;
using System.Globalization;

namespace Ex01.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrdemItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrdemItem item in Items)
            {
                total += item.Quantity * item.Price;
            }
            return total;
        }

        public override string ToString()
        {
            double totalPrice = 0.0;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrdemItem item in Items)
            {
                sb.Append(item);
                sb.AppendLine();
                totalPrice += item.SubTotal();
            }

            sb.Append("Total price: $");
            sb.Append(totalPrice.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
