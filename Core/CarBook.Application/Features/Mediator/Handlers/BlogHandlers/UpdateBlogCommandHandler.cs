using Carbook.Domain.Entities;
using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BlogId);
           values.CreatedDate = request.CreatedDate;
            values.CategoryId = request.CategoryId;
            values.AuthorId = request.AuthorId;
            values.CoverImageURL = request.CoverImageURL;
            values.Title = request.Title;

            await _repository.UpdateAsync(values);
        }
    }
}
