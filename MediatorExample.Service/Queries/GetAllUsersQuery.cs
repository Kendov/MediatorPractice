using ApplicationCore.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Service.Queries
{
    public class GetAllUsersQuery : IRequest<List<User>>
    {
    }
}
