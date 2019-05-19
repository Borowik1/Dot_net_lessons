using System;
using System.Collections.Generic;
using Entities;

namespace DAL
{
    public class UsersDAO : IUserDAO
    {
        private List<User> users = new List<User>();

        public void Add(User user)
        {
            if (user == null) { throw new ArgumentException("user"); }

            users.Add(user);
        }

        public void Remove(User user)
        {
            users.Remove(user);
        }

        public IEnumerable<User> GetList()
        {
            return users;
        }
    }

    public class UsersDAOdb : IUserDAO
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Remove(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
