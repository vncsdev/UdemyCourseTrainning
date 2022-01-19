using System;
using System.Text;
using System.Collections.Generic;
using OrderSystem.Entities.Enums;

namespace OrderSystem.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", ");
                sb.Append(item.Product.Price.ToString("C"));
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: ");
                sb.Append(item.SubTotal());
            }

            return sb.ToString();
        }
    }
}
