using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DBMediateka.Models
{
    public class SongGenre
    {
        private DbMediatekaContext context;

        public int _songID { get; set; }

        public int _genreID { get; set; }
    }
}
