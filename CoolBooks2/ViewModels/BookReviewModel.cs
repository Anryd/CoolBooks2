using CoolBooks2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoolBooks2.ViewModels
{
    public class BookReviewModel
    {
        public Book Book { get; set; }
        public Review Review { get; set; }
    }
}