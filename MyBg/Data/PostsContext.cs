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

        // ---------------------------------------------- Get Routes ----------------------------------------------------- //

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

        // get one favorite
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

        //------------------------------------------------ Get Blogs //
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
                            blog.Tumbnails = reader.GetString(3);
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

        // get one blog
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
                            blog.Tumbnails = reader.GetString(3);
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

        // ------------------------------------------------------------ Post Routes ------------------------------------------- //

        public void NewFavorite(FavoriteModel favorite)
        {
            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO favorites(Title, Description, Tumbnails, Categories, Link, HTML) VALUES(@Title, @Description, @Tumbnails, @Categories, @Link, @HTML)", connection);
                command.Parameters.Add("@Title", MySqlDbType.String).Value = favorite.ID;
                command.Parameters.Add("@Description", MySqlDbType.String).Value = favorite.Description;
                command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = favorite.Tumbnails;
                command.Parameters.Add("@Categories", MySqlDbType.String).Value = favorite.Categories;
                command.Parameters.Add("@Link", MySqlDbType.String).Value = favorite.Link;
                command.Parameters.Add("@HTML", MySqlDbType.String).Value = favorite.HTML;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(MySqlException e)
                {
                    Console.WriteLine(e);
                }
                connection.Close();
            }
        }


        public void NewBlog(BlogModel blog)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO blogs(Title, Description, Tumbnails, Categories, HTML) VALUES(@Title, @Description, @Tumbnails, @Categories, @HTML)", connection);
                command.Parameters.Add("@Title", MySqlDbType.String).Value = blog.ID;
                command.Parameters.Add("@Description", MySqlDbType.String).Value = blog.Description;
                command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = blog.Tumbnails;
                command.Parameters.Add("@Categories", MySqlDbType.String).Value = blog.Categories;
                command.Parameters.Add("@HTML", MySqlDbType.String).Value = blog.HTML;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                connection.Close();
            }
        }


        // ------------------------------------------------------------ Edit Routes ------------------------------------------- //
        public string EditFavorite(FavoriteModel favorite)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("UPDATE favorites SET Title = @Title, Description = @Description, Tumbnails = @Tumbnails, Categories = @Categories, Link = @Link, HTML = @HTML WHERE ID = @ID", connection);
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = favorite.ID;
                command.Parameters.Add("@Title", MySqlDbType.String).Value = favorite.Title;
                command.Parameters.Add("@Description", MySqlDbType.String).Value = favorite.Description;
                command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = favorite.Tumbnails;
                command.Parameters.Add("@Categories", MySqlDbType.String).Value = favorite.Categories;
                command.Parameters.Add("@Link", MySqlDbType.String).Value = favorite.Link;
                command.Parameters.Add("@HTML", MySqlDbType.String).Value = favorite.HTML;

                try
                {
                    connection.Open();
                    string resp = "this rows were affectd: ";
                    return resp + command.ExecuteNonQuery().ToString();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    return e.ToString();
                }
                connection.Close();
            }
        }

        public void EditBlog(BlogModel blog)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("UPDATE blogs SET Title = @Title, Description = @Description, Tumbnails = @Tumbnails, Categories = @Categories, HTML = @HTML WHERE ID = @ID", connection);
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = blog.ID;
                command.Parameters.Add("@Title", MySqlDbType.String).Value = blog.Title;
                command.Parameters.Add("@Description", MySqlDbType.String).Value = blog.Description;
                command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = blog.Tumbnails;
                command.Parameters.Add("@Categories", MySqlDbType.String).Value = blog.Categories;
                command.Parameters.Add("@HTML", MySqlDbType.String).Value = blog.HTML;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                connection.Close();
            }
        }

        // ------------------------------------------ Delete Routes ------------------------------------------------------ //
        public void DeleteFavorite(int ID)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("DELETE FROM favorites WHERE ID = @ID", connection);
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

                    command.ExecuteNonQuery();
                }
                catch(MySqlException e)
                {
                    Console.WriteLine(e);
                }
                connection.Close();
            }
        }

        public void DeleteBlog(int ID)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("DELETE FROM blogs WHERE ID = @ID", connection);
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;


                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                connection.Close();
            }
        }
    }
}
