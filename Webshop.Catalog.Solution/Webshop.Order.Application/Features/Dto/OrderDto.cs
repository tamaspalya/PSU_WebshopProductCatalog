namespace Webshop.Order.Application.Features.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public string Address { get; set; }
    }
}
