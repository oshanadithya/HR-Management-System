using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management_System.Models
{
    public class User
    {
        public int UserId { get; set; }
        public DateOnly regDate { get; set; }
        public string sname { get; set; }
        public string nic { get; set; }
        public string program { get; set; }
        public string sid { get; set; }
        public string gen { get; set; }
        public string address { get; set; }
        public string cno { get; set; }
        public string semail { get; set; }

    }
}
