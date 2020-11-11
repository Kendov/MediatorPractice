using ApplicationCore.Models;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorExample.Service
{
    public class UserService : IUserService
    {
        private ApplicationContext _context;
        public UserService(ApplicationContext context)
        {
            _context = context;
        }
        public User GetById(int id)
        {
            return _context.User.Find(id);
        }

        public List<User> List()
        {
            return _context.User.ToList();
        }

        public void Post(UserDto user)
        {
            User newEntry = new User
            {
                Name = user.Name,
                Age = user.Age,
                CreatedAt = DateTime.Now
                
            };
            _context.User.Add(newEntry);
            _context.SaveChanges();

        }
    }
}
