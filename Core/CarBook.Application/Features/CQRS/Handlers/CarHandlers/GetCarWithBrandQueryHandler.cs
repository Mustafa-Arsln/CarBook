using Carbook.Domain.Entities;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values =  _repository.GetCarsListWithBrands();

            return values.Where(x => !x.IsDeleted).Select(x => new GetCarWithBrandQueryResult
            {
                BradName=x.Brand.Name,
                BrandId = x.BrandId,
                BigImageURL = x.BigImageURL,
                CarId = x.CarId,
                CoverImageURL = x.CoverImageURL,
                Fuel = x.Fuel,
                Km = x.Km,
                Lougage = x.Lougage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission


            }).ToList();
        }
    }
}
