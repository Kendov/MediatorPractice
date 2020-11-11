using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Infrastructure;
using MediatorExample.Service;
using MediatorExample.Service.Command;
using MediatorExample.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatorExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
      

        private readonly ILogger<UserController> _logger;
        private readonly IMediator _mediator;

        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            var result = _mediator.Send(new GetAllUsersQuery());
            return result.Result;
        }

        //[HttpGet("{id}")]
        //public ActionResult<User> Get(int id)
        //{
        //    return Ok(_service.GetById(id));
        //}

        [HttpPost]
        public ActionResult Post([FromBody]UserDto userEntry)
        {

            _mediator.Send(new CreateUserCommand { User = userEntry });
            return Ok();
        }

    }
}
