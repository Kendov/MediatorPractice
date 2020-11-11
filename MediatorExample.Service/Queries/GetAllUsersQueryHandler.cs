using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Infrastructure;
using MediatR;

namespace MediatorExample.Service.Queries
{
    class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly IUserService _service;
        public GetAllUsersQueryHandler(IUserService service)
        {
            _service = service;
        }
        public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_service.List());
        }
    }
}
