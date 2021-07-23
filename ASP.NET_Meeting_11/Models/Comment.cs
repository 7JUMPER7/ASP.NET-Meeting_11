using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Meeting_11.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string UserName { get; set; }
        public int GoodId { get; set; }
        public virtual Good Good { get; set; }
    }
}