using Carbook.Domain.Entities;
using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;
        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandId=values.BrandId,
                BigImageURL=values.BigImageURL,
                Transmission=values.Transmission,
                Seat=values.Seat,
                Model=values.Model,
                CarId=values.CarId,
                CoverImageURL=values.CoverImageURL,
                Fuel=values.Fuel,
                Km=values.Km,
                Lougage = values.Lougage
               
                


            };
        }
    }
}
