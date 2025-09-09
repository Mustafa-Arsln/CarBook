using Carbook.Domain.Entities;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            
            return values.Where(x => !x.IsDeleted).Select(x => new GetCarQueryResult
            {
                
                BrandId = x.BrandId,
                BigImageURL = x.BigImageURL,
                CarId = x.CarId,
                CoverImageURL = x.CoverImageURL,
                Fuel=x.Fuel,
                Km=x.Km,
                 Lougage=x.Lougage,
                  Model=x.Model,
                  Seat=x.Seat,
                  Transmission = x.Transmission


            }).ToList();
        }
    }
}
