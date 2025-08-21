using Carbook.Domain.Entities;
using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {

        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageURL = command.BigImageURL,
                Lougage=command.Lougage,
                Km=command.Km,
                 Model=command.Model,
                 Seat=command.Seat,
                 Transmission=command.Transmission,
                 CoverImageURL=command.CoverImageURL,
                 BrandId=command.BrandId,
                 Fuel=command.Fuel,
                 



            });
        }
    }
}

