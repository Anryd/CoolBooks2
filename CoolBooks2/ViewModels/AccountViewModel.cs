using CoolBooks2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoolBooks2.ViewModels
{
    public class AccountViewModel
    {
        public User User { get; set; }
        public AspNetUser AspNetUser { get; set; }
        public AspNetRole AspNetRole { get; set; }
    }
}