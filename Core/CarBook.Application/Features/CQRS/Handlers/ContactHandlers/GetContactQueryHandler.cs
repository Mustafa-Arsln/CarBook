using Carbook.Domain.Entities;
using CarBook.Application.Features.CQRS.Results.ContactResults;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return values.Where(x => !x.IsDeleted).Select(x => new GetContactQueryResult

            {
                ContactId = x.ContactId,
                    Name = x.Name,
                    Massege = x.Massege,
                    SendDate = x.SendDate,
                    Subject = x.Subject,
                    Email = x.Email
                    
            }).ToList();
        }
    }
}
