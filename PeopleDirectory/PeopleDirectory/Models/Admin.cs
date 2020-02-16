﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeopleDirectory.Models
{
    public class Admin
    {
        //[Key]
        //public int UserId { get; set; }
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
    }
}