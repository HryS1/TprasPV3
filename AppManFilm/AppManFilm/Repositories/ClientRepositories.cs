using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppManFilm.Models;
using Microsoft.Data.SqlClient;

namespace AppManFilm.Repositories
{
    public class ClientRepositories
    {
        private readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=winformdb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public List<Client> GetClients()
        {
            var isfilm = new List<Client>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string sql = "SELECT * FROM isfilm ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.film = reader.GetString(1);
                                client.genre = reader.GetString(2);
                                client.tahun = reader.GetString(3);
                                client.sutradara = reader.GetString(4);
                                client.createdAt = reader.GetDateTime(5).ToString();

                                isfilm.Add(client);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return isfilm;
        }


        public Client? GetClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM isfilm WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.film = reader.GetString(1);
                                client.genre = reader.GetString(2);
                                client.tahun = reader.GetString(3);
                                client.sutradara = reader.GetString(4);
                                client.createdAt = reader.GetDateTime(5).ToString();

                                return client;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }


            return null;
        }



        public void CreateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO isfilm " +
                                 "(film, genre, tahun, sutradara) VALUES " +
                                 "(@film, @genre, @tahun, @sutradara);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@film", client.film);
                        command.Parameters.AddWithValue("@genre", client.genre);
                        command.Parameters.AddWithValue("@tahun", client.tahun);
                        command.Parameters.AddWithValue("@sutradara", client.sutradara);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }



        public void UpdateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE isfilm " +
                                 "SET film=@film, genre=@genre, " +
                                 "tahun=@tahun, sutradara=@sutradara " +
                                 "WHERE id=@id";


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@film", client.film);
                        command.Parameters.AddWithValue("@genre", client.genre);
                        command.Parameters.AddWithValue("@tahun", client.tahun);
                        command.Parameters.AddWithValue("@sutradara", client.sutradara);
                        command.Parameters.AddWithValue("@id", client.id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }



        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM isfilm WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
