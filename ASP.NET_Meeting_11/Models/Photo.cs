using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_Meeting_11.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public byte[] PhotoData { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }
    }
}