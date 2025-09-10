using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Domain.Entities
{
    public class CarPricing : BaseEntity
    {
        public int CarPricingId {  get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Amount { get; set; }
    }
}
