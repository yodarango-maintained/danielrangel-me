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
                MySqlCommand command = new MySqlCommand("SELECT * FROM Favorites ORDER BY ID DESC LIMIT 10;", connection);
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
                            favorite.Link = reader.GetString(6);
                            favorite.HTML = reader.GetString(7);
                            favorite.PostType = reader.GetString(8);


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
                MySqlCommand command = new MySqlCommand("SELECT * FROM Favorites WHERE ID = @ID", connection);

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
                            favorite.Link = reader.GetString(6);
                            favorite.HTML = reader.GetString(7);
                            favorite.PostType = reader.GetString(8);

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
        public List<ArticleModel> GetBlogs()
        {
            List<ArticleModel> blogs = new List<ArticleModel>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Blogs ORDER BY ID DESC LIMIT 10", connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            ArticleModel blog = new ArticleModel();

                            blog.ID = reader.GetInt32(0);
                            blog.Title = reader.GetString(1);
                            blog.Description = reader.GetString(2);
                            blog.Tumbnails = reader.GetString(3);
                            blog.Categories = reader.GetString(4);
                            blog.DatePosted = reader.GetDateTime(5);
                            blog.HTML = reader.GetString(6);
                            blog.PostType = reader.GetString(7);

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
        public ArticleModel GetOneBlog(int ID)
        {

            ArticleModel blog = new ArticleModel();

            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Blogs WHERE ID = @ID", connection);
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
                            blog.DatePosted = reader.GetDateTime(5);
                            blog.HTML = reader.GetString(6);
                            blog.PostType = reader.GetString(7);

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


        public List<PostsViewModel> GetAllPosts()
        {
            List<PostsViewModel> allPosts = new List<PostsViewModel>();

            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("(SELECT ID, Title, Description, Tumbnails, Categories, DatePosted, PostType FROM Blogs ORDER BY ID DESC) UNION ALL (SELECT ID, Title, Description, Tumbnails, Categories, DatePosted, PostType FROM Favorites ORDER BY ID DESC) ORDER BY DatePosted LIMIT 10;", connection);
                
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            PostsViewModel post = new PostsViewModel();

                            post.ID = reader.GetInt32(0);
                            post.Title = reader.GetString(1);
                            post.Description = reader.GetString(2);
                            post.Tumbnails = reader.GetString(3);
                            post.Categories = reader.GetString(4);
                            post.DatePosted = reader.GetDateTime(5);
                            post.PostType = reader.GetString(6);

                            allPosts.Add(post);
                        }
                    }
                    reader.Close();

                }
                catch(MySqlException e)
                {
                    Console.WriteLine(e);
                }
                connection.Close();
            }

            return allPosts;
        }

        public List<PostsViewModel> GetPostsByTag(string tag)
        {
            List<PostsViewModel> allPosts = new List<PostsViewModel>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("(SELECT ID, Title, Description, Tumbnails, Categories, DatePosted, PostType FROM Blogs WHERE Categories LIKE '%" + @tag + "%' ORDER BY ID DESC) UNION ALL (SELECT ID, Title, Description, Tumbnails, Categories, DatePosted, PostType FROM Favorites WHERE Categories LIKE '%" + @tag + "%' ORDER BY ID DESC) ORDER BY DatePosted;", connection);
                command.Parameters.Add("@tag", MySqlDbType.String).Value = tag;

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            PostsViewModel post = new PostsViewModel();

                            post.ID = reader.GetInt32(0);
                            post.Title = reader.GetString(1);
                            post.Description = reader.GetString(2);
                            post.Tumbnails = reader.GetString(3);
                            post.Categories = reader.GetString(4);
                            post.DatePosted = reader.GetDateTime(5);
                            post.PostType = reader.GetString(6);

                            allPosts.Add(post);
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

            return allPosts;
        }

        public List<CategoryModel> GetCategoryTags()
        {

            List<CategoryModel> tags = new List<CategoryModel>();

            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM categories ORDER By Category ASC", connection);

                try {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            CategoryModel tag = new CategoryModel();

                            tag.ID = reader.GetInt32(0);
                            tag.Category = reader.GetString(1);

                            tags.Add(tag);
                        }
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
            }
            return tags;
        }

        // ------------------------------------------------------------ Post Routes ------------------------------------------- //

        //public void NewFavorite(FavoriteModel favorite)
        //{
        //    using(MySqlConnection connection = GetConnection())
        //    {
        //        MySqlCommand command = new MySqlCommand("INSERT INTO Favorites(PostType, Title, Description, Tumbnails, Categories, Link, HTML) VALUES(Favorite, @Title, @Description, @Tumbnails, @Categories, @Link, @HTML)", connection);

        //        command.Parameters.Add("@Title", MySqlDbType.String).Value = favorite.ID;
        //        command.Parameters.Add("@Description", MySqlDbType.String).Value = favorite.Description;
        //        command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = favorite.Tumbnails;
        //        command.Parameters.Add("@Categories", MySqlDbType.String).Value = favorite.Categories;
        //        command.Parameters.Add("@Link", MySqlDbType.String).Value = favorite.Link;
        //        command.Parameters.Add("@HTML", MySqlDbType.String).Value = favorite.HTML;

        //        try
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //        catch(MySqlException e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //        connection.Close();
        //    }
        //}


        //public void NewBlog(ArticleModel blog)
        //{
        //    using (MySqlConnection connection = GetConnection())
        //    {
        //        MySqlCommand command = new MySqlCommand("INSERT INTO blogs(PostType, Title, Description, Tumbnails, Categories, HTML) VALUES(Blog, @Title, @Description, @Tumbnails, @Categories, @HTML)", connection);
        //        command.Parameters.Add("@Title", MySqlDbType.String).Value = blog.ID;
        //        command.Parameters.Add("@Description", MySqlDbType.String).Value = blog.Description;
        //        command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = blog.Tumbnails;
        //        command.Parameters.Add("@Categories", MySqlDbType.String).Value = blog.Categories;
        //        command.Parameters.Add("@HTML", MySqlDbType.String).Value = blog.HTML;

        //        try
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //        catch (MySqlException e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //        connection.Close();
        //    }
        //}


        //// ------------------------------------------------------------ Edit Routes ------------------------------------------- //
        //public string EditFavorite(FavoriteModel favorite)
        //{
        //    using (MySqlConnection connection = GetConnection())
        //    {
        //        MySqlCommand command = new MySqlCommand("UPDATE Favorites SET Title = @Title, Description = @Description, Tumbnails = @Tumbnails, Categories = @Categories, Link = @Link, HTML = @HTML WHERE ID = @ID", connection);
        //        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = favorite.ID;
        //        command.Parameters.Add("@Title", MySqlDbType.String).Value = favorite.Title;
        //        command.Parameters.Add("@Description", MySqlDbType.String).Value = favorite.Description;
        //        command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = favorite.Tumbnails;
        //        command.Parameters.Add("@Categories", MySqlDbType.String).Value = favorite.Categories;
        //        command.Parameters.Add("@Link", MySqlDbType.String).Value = favorite.Link;
        //        command.Parameters.Add("@HTML", MySqlDbType.String).Value = favorite.HTML;

        //        try
        //        {
        //            connection.Open();
        //            string resp = "this rows were affectd: ";
        //            return resp + command.ExecuteNonQuery().ToString();
        //        }
        //        catch (MySqlException e)
        //        {
        //            Console.WriteLine(e);
        //            return e.ToString();
        //        }
        //    }
        //}

        //public void EditBlog(ArticleModel blog)
        //{
        //    using (MySqlConnection connection = GetConnection())
        //    {
        //        MySqlCommand command = new MySqlCommand("UPDATE Blogs SET Title = @Title, Description = @Description, Tumbnails = @Tumbnails, Categories = @Categories, HTML = @HTML WHERE ID = @ID", connection);
        //        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = blog.ID;
        //        command.Parameters.Add("@Title", MySqlDbType.String).Value = blog.Title;
        //        command.Parameters.Add("@Description", MySqlDbType.String).Value = blog.Description;
        //        command.Parameters.Add("@Tumbnails", MySqlDbType.String).Value = blog.Tumbnails;
        //        command.Parameters.Add("@Categories", MySqlDbType.String).Value = blog.Categories;
        //        command.Parameters.Add("@HTML", MySqlDbType.String).Value = blog.HTML;

        //        try
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //        catch (MySqlException e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //        connection.Close();
        //    }
        //}

        //// ------------------------------------------ Delete Routes ------------------------------------------------------ //
        //public void DeleteFavorite(int ID)
        //{
        //    using (MySqlConnection connection = GetConnection())
        //    {
        //        try
        //        {
        //            connection.Open();

        //            MySqlCommand command = new MySqlCommand("DELETE FROM Favorites WHERE ID = @ID", connection);
        //            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

        //            command.ExecuteNonQuery();
        //        }
        //        catch(MySqlException e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //        connection.Close();
        //    }
        //}

        //public void DeleteBlog(int ID)
        //{
        //    using (MySqlConnection connection = GetConnection())
        //    {
        //        try
        //        {
        //            connection.Open();

        //            MySqlCommand command = new MySqlCommand("DELETE FROM Blogs WHERE ID = @ID", connection);
        //            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;


        //            command.ExecuteNonQuery();
        //        }
        //        catch (MySqlException e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //        connection.Close();
        //    }
        //}
    }
}
