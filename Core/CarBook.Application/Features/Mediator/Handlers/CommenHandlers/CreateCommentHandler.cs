using Carbook.Domain.Entities;
using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommenHandlers
{
    internal class CreateCommentHandler : IRequestHandler<CreateCommentCommand>
    {

        private readonly IRepository<Comment> _repository;

        public CreateCommentHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

  
        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Comment
            {
             Description=request.Description,
             Name=request.Name,
             CreatedDate=DateTime.Parse(DateTime.Now.ToShortDateString()),
                BlogId =request.BlogId,
                EMail=request.EMail

            });
        }
    }
}
