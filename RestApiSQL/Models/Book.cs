﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApiSQL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PageCount { get; set; }
    }
}