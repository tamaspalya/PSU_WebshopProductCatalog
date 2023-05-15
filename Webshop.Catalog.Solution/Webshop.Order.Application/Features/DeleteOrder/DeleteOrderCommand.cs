using EnsureThat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Application.Contracts;

namespace Webshop.Order.Application.Features.DeleteOrder
{
    public class DeleteOrderCommand: ICommand
    {
        public int OrderId { get; set; }
        public DeleteOrderCommand(int orderId) 
        {
            Ensure.That(orderId, nameof(orderId)).IsNotDefault<int>(); //no default, or zero
            Ensure.That(orderId, nameof(orderId)).IsGt<int>(0); //no negative id
            OrderId = orderId;
        }
    }
}
