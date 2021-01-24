using System;
using System.Collections.Generic;

#nullable disable

namespace _2001_Web_Api.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
