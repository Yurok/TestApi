using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Repository.Models {
    public class APart {
        public int id { get; set; }
        public string name { get; set; }
        public string orig_article { get; set; }
        public string description { get; set; }
        public string full_description { get; set; }
        public string applicability { get; set; }
        public string price { get; set; }
        public string url_img { get; set; }
    }
}