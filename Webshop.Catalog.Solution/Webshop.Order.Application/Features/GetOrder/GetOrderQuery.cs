using EnsureThat;
using Webshop.Application.Contracts;
using Webshop.Order.Application.Features.Dto;

namespace Webshop.Order.Application.Features.GetOrder
{
    public class GetOrderQuery : IQuery<OrderDto>
    {
        public int OrderId { get; set; }
        public GetOrderQuery(int orderId)
        {
            Ensure.That(orderId, nameof(orderId)).IsNotDefault<int>();
            Ensure.That(orderId, nameof(orderId)).IsGt<int>(0);
            OrderId = orderId;
        }
    }
}
