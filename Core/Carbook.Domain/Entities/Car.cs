using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Domain.Entities
{
    public class Car
    { 
        public int CarId { get; set; }
        public int BrandId  { get; set; }
        public Brand Brand  { get; set; }
        public string Model { get; set; }
        public string CoverİmageURL { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public int Seat { get; set; }
        public int Lougage { get; set; }
        public string Fuel { get; set; }
        public string BigİmageURL { get; set; }
        public List<CarFeature> CarFeature { get; set; }
        public List<CarDescription> CarDescription { get; set; }
        public List<CarPricing> CarPricings { get; set; }

    }
}
