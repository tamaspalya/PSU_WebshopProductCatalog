using Webshop.Domain.Common;

namespace Webshop.Domain.AggregateRoots
{
    public class Order: AggregateRoot
    {
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
    }
}
