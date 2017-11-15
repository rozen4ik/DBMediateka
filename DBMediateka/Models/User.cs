using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DBMediateka.Models
{
    public class User
    {
        private DbMediatekaContext context;

        public int _id { get; set; }

        public string _first_name { get; set; }

        public string _last_name { get; set; }

        public string _sex { get; set; }

        public string _birth_date { get; set; }

        public int _cityID { get; set; }

        public string _email { get; set; }

        public string _password { get; set; }
    }
}
