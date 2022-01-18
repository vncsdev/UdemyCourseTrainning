using System;
using AulaEnum.Entities;
using AulaEnum.Entities.Enums;

namespace AulaEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //converter enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //converter string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
