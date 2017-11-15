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

        public List<SongAlbum> GetAllSongAlbum()
        {
            List<SongAlbum> list = new List<SongAlbum>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _song_album", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SongAlbum()
                        {                            
                            _songID = reader.GetInt32("_songID"),
                            _albumID = reader.GetInt32("_albumID"),
                            _track_no = reader.GetString("_track_no")
                        });
                    }
                }
            }
            return list;
        }

        public List<Album> GetAllAlbum()
        {
            List<Album> list = new List<Album>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _album", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Album()
                        {
                            _id = reader.GetInt32("_id"),
                            _title = reader.GetString("_title"),
                            _year = reader.GetString("_year"),
                            _artistID = reader.GetInt32("_artistID")
                        });
                    }
                }
            }
            return list;
        }

        public List<SongArtist> GetAllSongArtist()
        {
            List<SongArtist> list = new List<SongArtist>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _song_artist", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SongArtist()
                        {
                            _songID = reader.GetInt32("_songID"),
                            _artistID = reader.GetInt32("_artistID")
                        });
                    }
                }
            }
            return list;
        }

        public List<Song> GetAllSong()
        {
            List<Song> list = new List<Song>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _song", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Song()
                        {
                            _id = reader.GetInt32("_id"),
                            _title = reader.GetString("_title")
                        });
                    }
                }
            }
            return list;
        }

        public List<SongGenre> GetAllSongGenre()
        {
            List<SongGenre> list = new List<SongGenre>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _song_genre", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SongGenre()
                        {
                            _songID = reader.GetInt32("_songID"),
                            _genreID = reader.GetInt32("_genreID")
                        });
                    }
                }
            }
            return list;
        }

        public List<Genre> GetAllGenre()
        {
            List<Genre> list = new List<Genre>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM _genre", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Genre()
                        {
                            _id = reader.GetInt32("_id"),
                            _name = reader.GetString("_name")
                        });
                    }
                }
            }
            return list;
        }
    }
}
