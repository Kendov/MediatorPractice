using ApplicationCore.Models;
using Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.Service.Command
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserService _service;
        public CreateUserCommandHandler(IUserService service)
        {
            _service = service;
        }

        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _service.Post(request.User);
            return Unit.Task;
        }

    }
}
