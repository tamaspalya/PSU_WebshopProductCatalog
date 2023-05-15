using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Application.Contracts;

namespace Webshop.Order.Application.Features.CreateOrder
{
    public class CreateOrderCommand: ICommand
    {
        public Domain.AggregateRoots.Order Order { get; set; }
        public CreateOrderCommand(Domain.AggregateRoots.Order order) 
        {
            Order = order;
        }
    }
}
