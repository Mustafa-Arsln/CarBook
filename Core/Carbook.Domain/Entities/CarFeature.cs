using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public Car Car  { get; set; }
        public int FeatureId { get; set; }
        public Feature Fature { get; set; }
        public bool Availeble { get; set; }
    }
}
