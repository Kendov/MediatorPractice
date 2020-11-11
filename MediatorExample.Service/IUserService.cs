using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Service
{
    public interface IUserService
    {
        void Post(UserDto user);
        List<User> List();
        User GetById(int id);
    }
}
