using MassTransit;
using Model;
using System;
using System.Threading.Tasks;

namespace InventoryService
{
    internal class OrderItemConsumer : IConsumer<OrderItem>
    {
        public async Task Consume(ConsumeContext<OrderItem> context)
        {
            await Console.Out.WriteLineAsync(context.Message.ItemName);
        }
    }
}