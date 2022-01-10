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
                MySqlCommand command = new MySqlCommand("SELECT * FROM useradmin ORDER BY ID DESC LIMIT 1", connection);

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
                            user.Discord_url = reader.GetString(11);
                            user.Codepen_url = reader.GetString(12);
                            user.Categories = reader.GetString(13);
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

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM followers ORDER BY ID DESC", connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FollowerModel follower = new FollowerModel();
                            follower.ID = reader.GetInt32(0);
                            follower.Follower_Name = reader.GetString(1);
                            follower.Email = reader.GetString(2);
                            follower.Date_Subscribed = reader.GetDateTime(3);
                            follower.Not_A_Bot = reader.GetBoolean(4);
                            follower.Avatar = reader.GetString(5);

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

        // -------------------------------------- Post Routes ------------------------------------------ //
        public void EditUserAdmin(UserAdminModel admin)
        {
            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand command = new MySqlCommand("UPDATE UserAdmin SET About_Me = @About_Me, YouVersion_Url = @YouVersion_Url, Github_Url = @Github_Url, Instagram_Url = @Instagram_Url, Reddit_Url = @Reddit_Url, Goodreads_url = @Goodreads_url, Youtube_url = @Youtube_url, Twitter_url = @Twitter_url, LinkedIn_url = @LinkedIn_url, Strava_url = @Strava_url, Discord_url = @Discord_url, Codepen_url = @Codepen_url, Categories = @Categories WHERE ID  = @ID", connection);

                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = admin.ID;
                command.Parameters.Add("@About_Me", MySqlDbType.String).Value = admin.About_Me;
                command.Parameters.Add("@YouVersion_Url", MySqlDbType.String).Value = admin.YouVersion_Url;
                command.Parameters.Add("@Github_Url", MySqlDbType.String).Value = admin.Github_Url;
                command.Parameters.Add("@Instagram_Url", MySqlDbType.String).Value = admin.Instagram_Url;
                command.Parameters.Add("@Reddit_Url", MySqlDbType.String).Value = admin.Reddit_Url;
                command.Parameters.Add("@Goodreads_url", MySqlDbType.String).Value = admin.Goodreads_url;
                command.Parameters.Add("@Youtube_url", MySqlDbType.String).Value = admin.Youtube_url;
                command.Parameters.Add("@Twitter_url", MySqlDbType.String).Value = admin.Twitter_url;
                command.Parameters.Add("@LinkedIn_url", MySqlDbType.String).Value = admin.LinkedIn_url;
                command.Parameters.Add("@Strava_url", MySqlDbType.String).Value = admin.Strava_url;
                command.Parameters.Add("@Discord_url", MySqlDbType.String).Value = admin.Discord_url;
                command.Parameters.Add("@Codepen_url", MySqlDbType.String).Value = admin.Codepen_url;
                command.Parameters.Add("@Categories", MySqlDbType.String).Value = admin.Categories;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                }

            }
        }

        public int GetFollowerCount()
        {
            int followers = 0;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM followers", connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            followers = reader.FieldCount;
                        }
                    }
                    reader.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                connection.Close();
            }

            return followers;
        }
    }
}

