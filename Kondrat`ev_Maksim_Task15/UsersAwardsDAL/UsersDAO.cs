using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAwardsDAL
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

        public void Edit(User user)
        {
            foreach (User us in users)
            {
                if (us.Id == user.Id)
                {
                    us.FirstName = user.FirstName;
                    us.LastName = user.LastName;
                    us.DateOfBirth = user.DateOfBirth;
                    us.Awards = user.Awards;
                }
            }
        }

        public IEnumerable<User> GetList()
        {
            return users;
        }
    }

    public class UsersDAOdb : IUserDAO
    {
        private string connectionString = ConfigurationManager
            .ConnectionStrings["MyConnectionString"].ConnectionString;

        public void Add(User user)
        {
            DataTable awardsIds = new DataTable();
            awardsIds.Columns.Add(new DataColumn("id", typeof(int)));
            foreach (Award aw in user.Awards)
            {
                awardsIds.Rows.Add(aw.AwardId);
            }
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("AddUser"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    command.Parameters.AddWithValue("@AwardsIDS", awardsIds);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remove(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("DeleteUser"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Id", user.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<User> GetList()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SELECT * FROM Users"))
                {
                    command.Connection = connection;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        return users;
                    }

                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var firstName = reader.GetString(1);
                        var lastName = reader.GetString(2);
                        var dateOfBirth = reader.GetDateTime(3);

                        var user = new User(id, firstName, lastName, dateOfBirth, new List<Award>());
                        users.Add(user);
                    }
                }
            }
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("select * From Relations, Awards where Relations.AwardId = Awards.Id"))
                {
                    command.Connection = connection;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    var award = new Award();

                    if (!reader.HasRows)
                    {
                        return users;
                    }

                    while (reader.Read())
                    {
                        foreach (User us in users)
                        {
                            if (us.Id == reader.GetInt32(1))
                            {
                                us.Awards.Add(new Award(reader.GetInt32(2),
                                                        reader.GetString(4),
                                                        reader.GetString(5)));
                            }
                        }
                    }
                }
            }
            return users;
        }

        public void Edit(User user)
        {
            DataTable awardsIds = new DataTable();
            awardsIds.Columns.Add(new DataColumn("id", typeof(int)));
            foreach (Award aw in user.Awards)
            {
                awardsIds.Rows.Add(aw.AwardId);
            }

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("EditUser"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    command.Parameters.AddWithValue("@AwardsIds", awardsIds);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
