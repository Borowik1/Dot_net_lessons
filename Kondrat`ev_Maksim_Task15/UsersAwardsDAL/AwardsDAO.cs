using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAwardsDAL
{
    public class AwardsDAO : IAwardDAO
    {
        private List<Award> awards = new List<Award>();

        public void Add(Award award)
        {
            if (award == null) { throw new ArgumentException("award"); }

            awards.Add(award);
        }

        public void Remove(Award award)
        {
            awards.Remove(award);
        }

        public void Edit(Award award)
        {
            foreach (Award aw in awards)
            {
                if (award.AwardId == aw.AwardId)
                {
                    aw.AwardName = award.AwardName;
                    aw.AwardDescription = award.AwardDescription;
                }
            }
        }

        public IEnumerable<Award> GetList()
        {
            return awards;
        }
    }

    public class AwardsDAOdb : IAwardDAO
    {
        private string connectionString = ConfigurationManager
            .ConnectionStrings["MyConnectionString"].ConnectionString;

        public void Add(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("AddAward"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@AwardName", award.AwardName);
                    command.Parameters.AddWithValue("@AwardDesc", award.AwardDescription);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remove(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("DeleteAward"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Id", award.AwardId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Award> GetList()
        {
            var awards = new List<Award>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SELECT * FROM Awards"))
                {
                    command.Connection = connection;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        return awards;
                    }

                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var desc = reader.GetString(2);

                        var award = new Award(id, name, desc);
                        awards.Add(award);
                    }
                    return awards;
                }               
            }
        }
        public void Edit(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("EditAward"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Id", award.AwardId);
                    command.Parameters.AddWithValue("@AwardName", award.AwardName);
                    command.Parameters.AddWithValue("@AwardDesc", award.AwardDescription);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
