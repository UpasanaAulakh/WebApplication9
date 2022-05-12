using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class product
    {

        public int id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public int price { get; set; }
        public string Description { get; set; }
        public categary  categary{ get; set; }

    }
}