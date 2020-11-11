using ApplicationCore.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Service.Command
{
    public class CreateUserCommand : IRequest
    {
        public UserDto User { get; set; }
    }
}
