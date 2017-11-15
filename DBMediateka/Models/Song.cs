﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DBMediateka.Models
{
    public class Song
    {
        private DbMediatekaContext context;

        public int _id { get; set; }

        public string _title { get; set; }
    }
}
