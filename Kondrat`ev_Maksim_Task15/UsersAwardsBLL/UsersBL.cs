﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAwardsDAL;

namespace UsersAwardsBLL
{
    public class UsersBL
    {
        private readonly IUserDAO usersDAO;

        public UsersBL()
        {
            usersDAO = new UsersDAOdb();
        }

        public IEnumerable<User> InitList()
        {
            return GetList();
        }

        public IEnumerable<User> SortUsersByFirstNameAsc()
        {
            return (from u in GetList()
                    orderby u.FirstName ascending
                    select u).ToList();
        }

        public IEnumerable<User> SortUsersByFirstNameDesc()
        {
            return (from u in GetList()
                    orderby u.FirstName descending
                    select u).ToList();
        }

        public IEnumerable<User> SortUsersByLastNameAsc()
        {
            return (from u in GetList()
                    orderby u.LastName ascending
                    select u).ToList();
        }

        public IEnumerable<User> SortUsersByLastNameDesc()
        {
            return (from u in GetList()
                    orderby u.LastName descending
                    select u).ToList();
        }

        public IEnumerable<User> SortUsersByAgeAsc()
        {
            return (from u in GetList()
                    orderby u.Age ascending
                    select u).ToList();
        }

        public IEnumerable<User> SortUsersByAgeDesc()
        {
            return (from u in GetList()
                    orderby u.Age descending
                    select u).ToList();
        }

        public void Add(User user)
        {
            if (user == null) { throw new ArgumentException("user"); }

            usersDAO.Add(user);
        }

        public void Remove(User user)
        {
            usersDAO.Remove(user);
        }

        public IEnumerable<User> GetList()
        {
            return usersDAO.GetList();
        }

        public void Edit(User user)
        {
            usersDAO.Edit(user);
        }
    }
}
