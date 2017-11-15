using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

namespace DBMediateka.Models
{
    public class DbMediatekaContext
    {
        public string ConnectionString { get; set; }

        public DbMediatekaContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Country> GetAllCountry()
        {
            List<Country> list = new List<Country>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _country", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Country()
                        {
                            _id = reader.GetInt32("_id"),
                            _name = reader.GetString("_name")
                        });
                    }
                }
            }
            return list;
        }

        public List<Artist> GetAllArtist()
        {
            List<Artist> list = new List<Artist>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _artist", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Artist()
                        {
                            _id = reader.GetInt32("_id"),
                            _name = reader.GetString("_name"),
                            _countryID = reader.GetInt32("_countryID")
                        });
                    }
                }
            }
            return list;
        }

        public List<City> GetAllCity()
        {
            List<City> list = new List<City>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _city", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new City()
                        {
                            _id = reader.GetInt32("_id"),
                            _name = reader.GetString("_name"),
                            _countryID = reader.GetInt32("_countryID")
                        });
                    }
                }
            }
            return list;
        }

        public List<User> GetAllUser()
        {
            List<User> list = new List<User>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _user", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            _id = reader.GetInt32("_id"),
                            _first_name = reader.GetString("_first_name"),
                            _last_name = reader.GetString("_last_name"),
                            _sex = reader.GetString("_sex"),
                            _birth_date = reader.GetString("_birth_date"),
                            _cityID = reader.GetInt32("_cityID"),
                            _email = reader.GetString("_email"),
                            _password = reader.GetString("_password")
                        });
                    }
                }
            }
            return list;
        }

        public List<Like> GetAllLike()
        {
            List<Like> list = new List<Like>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _like", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Like()
                        {
                            _userID = reader.GetInt32("_userID"),                   
                            _songID = reader.GetInt32("_songID"),
                            _score = reader.GetInt32("_score"),
                            _date = reader.GetString("_date")
                        });
                    }
                }
            }
            return list;
        }
    }
}
