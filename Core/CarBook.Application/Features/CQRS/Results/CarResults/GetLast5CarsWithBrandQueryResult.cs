using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarResults
{
    public class GetLast5CarsWithBrandQueryResult
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BradName { get; set; }
        public string Model { get; set; }
        public string CoverImageURL { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public int Seat { get; set; }
        public int Lougage { get; set; }
        public string Fuel { get; set; }
        public string BigImageURL { get; set; }
    }
}
