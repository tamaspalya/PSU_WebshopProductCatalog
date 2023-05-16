using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Domain.Common;

namespace Webshop.Order.Application.Features.Requests
{
    public class UpdateOrderRequest
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public class Validator : AbstractValidator<UpdateOrderRequest>
        {
            public Validator()
            {
                RuleFor(r => r.Id)
                   .NotNull().WithMessage(Errors.General.ValueIsRequired(nameof(Id)).Code)
                   .GreaterThanOrEqualTo(0).WithMessage(Errors.General.ValueTooSmall(nameof(Id), 1).Code);
                RuleFor(r => r.BuyerId)
                   .NotNull().WithMessage(Errors.General.ValueIsRequired(nameof(BuyerId)).Code)
                   .GreaterThanOrEqualTo(0).WithMessage(Errors.General.ValueTooSmall(nameof(BuyerId), 1).Code);
                RuleFor(r => r.SellerId)
                   .NotNull().WithMessage(Errors.General.ValueIsRequired(nameof(SellerId)).Code)
                   .GreaterThanOrEqualTo(0).WithMessage(Errors.General.ValueTooSmall(nameof(SellerId), 1).Code);

                RuleFor(r => r.Address).NotEmpty().WithMessage(Errors.General.ValueIsRequired(nameof(Address)).Code);
                RuleFor(r => r.City).NotEmpty().WithMessage(Errors.General.ValueIsRequired(nameof(City)).Code);
                RuleFor(r => r.Region).NotEmpty().WithMessage(Errors.General.ValueIsRequired(nameof(Region)).Code);
                RuleFor(r => r.PostalCode).NotEmpty().WithMessage(Errors.General.ValueIsRequired(nameof(PostalCode)).Code);
                RuleFor(r => r.Country).NotEmpty().WithMessage(Errors.General.ValueIsRequired(nameof(Country)).Code);
            }
        }
    }
}
