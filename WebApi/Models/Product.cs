﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string OwnerID { get; set; }
    }
}
