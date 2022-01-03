using MyBg.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Data
{
    public class PostsContext
    {
        public string ConnectionString { get; set; }

        public PostsContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<FavoriteModel> GetFavorites()
        {


            List<FavoriteModel> favorites = new List<FavoriteModel>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM favorites ORDER BY ID DESC LIMIT 10;", connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FavoriteModel favorite = new FavoriteModel();
                            favorite.ID = reader.GetInt32(0);
                            favorite.Title = reader.GetString(1);
                            favorite.Description = reader.GetString(2);
                            favorite.Tumbnails = reader.GetString(3);
                            favorite.Categories = reader.GetString(4);
                            favorite.DatePosted = reader.GetDateTime(5);
                            if (!reader.IsDBNull(6))
                            {
                                favorite.Link = reader.GetString(6);
                            }

                            favorite.HTML = reader.GetString(7);

                            favorites.Add(favorite);
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
            return favorites;
        }

        public FavoriteModel GetOneFavorite(int ID)
        {
            FavoriteModel favorite = new FavoriteModel();

            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM favorites WHERE ID = @ID", connection);

                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            favorite.ID = reader.GetInt32(0);
                            favorite.Title = reader.GetString(1);
                            favorite.Description = reader.GetString(2);
                            favorite.Tumbnails = reader.GetString(3);
                            favorite.Categories = reader.GetString(4);
                            favorite.DatePosted = reader.GetDateTime(5);
                            if (!reader.IsDBNull(6))
                            {
                                favorite.Link = reader.GetString(6);
                            }

                            favorite.HTML = reader.GetString(7);
                        }
                    }
                    reader.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
            }
            return favorite;  
        }

        public List<BlogModel> GetBlogs()
        {
            List<BlogModel> blogs = new List<BlogModel>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM blogs ORDER BY ID DESC LIMIT 10", connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            BlogModel blog = new BlogModel();
                            blog.ID = reader.GetInt32(0);
                            blog.Title = reader.GetString(1);
                            blog.Description = reader.GetString(2);
                            blog.Tumbnail = reader.GetString(3);
                            blog.Categories = reader.GetString(4);
                            blog.Date = reader.GetDateTime(5);
                            blog.HTML = reader.GetString(6);

                            blogs.Add(blog);
                        }
                    }
                }
                catch(MySqlException e)
                {
                    Console.WriteLine(e);
                }
            }
            return blogs;
        }

        public BlogModel GetOneBlog(int ID)
        {

            BlogModel blog = new BlogModel();

            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM blogs WHERE ID = @ID", connection);
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            blog.ID = reader.GetInt32(0);
                            blog.Title = reader.GetString(1);
                            blog.Description = reader.GetString(2);
                            blog.Tumbnail = reader.GetString(3);
                            blog.Categories = reader.GetString(4);
                            blog.Date = reader.GetDateTime(5);
                            blog.HTML = reader.GetString(6);
                        }
                    }
                    reader.Close();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
            }
            return blog;
        }
    }
}
