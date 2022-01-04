using MyBg.Models;
using MyBg.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Data
{
    public class UsersContext
    {
        public string ConnectionString { get; set; }

        public UsersContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        // get data for the index page
        public UserAdminModel Getindexdata()
        {
            UserAdminModel user = new UserAdminModel();
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("select * from useradmin where id = 1", connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            user.ID = reader.GetInt32(0);
                            user.About_Me = reader.GetString(1);
                            user.YouVersion_Url = reader.GetString(2);
                            user.Github_Url = reader.GetString(3);
                            user.Instagram_Url = reader.GetString(4);
                            user.Reddit_Url = reader.GetString(5);
                            user.Goodreads_url = reader.GetString(6);
                            user.Youtube_url = reader.GetString(7);
                            user.Twitter_url = reader.GetString(8);
                            user.LinkedIn_url = reader.GetString(9);
                            user.Strava_url = reader.GetString(10);
                            user.Categories = reader.GetString(11);
                        }

                    }
                    reader.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                connection.Close();
            }

            return user;
        }

        public List<FollowerModel> GetFollowers()
        {
            List<FollowerModel> followers = new List<FollowerModel>();

            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM followers ORDER BY ID DESC", connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            FollowerModel follower = new FollowerModel();
                            follower.ID = reader.GetInt32(0);
                            follower.Follower_Name = reader.GetString(1);
                            follower.Email = reader.GetString(2);
                            follower.Date_Subscribed = reader.GetDateTime(3);
                            follower.Not_A_Bot = reader.GetBoolean(4);

                            followers.Add(follower);
                        }
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }

                return followers;
            }
        }
    }
}

