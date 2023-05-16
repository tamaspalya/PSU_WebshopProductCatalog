using EnsureThat;
using Webshop.Application.Contracts;
using Webshop.Order.Application.Features.Dto;

namespace Webshop.Order.Application.Features.UpdateOrder
{
    public class UpdateOrderCommand: ICommand
    {
        public UpdateOrderCommand(Domain.AggregateRoots.Order order)
        {
            Ensure.That(order, nameof(order)).IsNotNull();
            Ensure.That(order.Id, nameof(order.Id)).IsNotDefault();
            Ensure.That(order.Id, nameof(order.Id)).IsGt<int>(0);
            Ensure.That(order.SellerId, nameof(order.SellerId)).IsGt<int>(0);
            Ensure.That(order.BuyerId, nameof(order.BuyerId)).IsGt<int>(0);
            Order = order;
        }

        public Domain.AggregateRoots.Order Order { get; private set; }
    }
}
