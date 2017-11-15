using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DBMediateka.Models
{
    public class Album
    {
        private DbMediatekaContext context;

        public int _id { get; set; }

        public string _title { get; set; }

        public string _year { get; set; }

        public int _artistID { get; set; }
    }
}
