using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DBMediateka.Models
{
    public class Like
    {
        private DbMediatekaContext context;

        public int _userID { get; set; }

        public int _songID { get; set; }

        public int _score { get; set; }

        public string _date { get; set; }
    }
}
