﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Movie> Movies { get; set; }
    }
}