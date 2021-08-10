using ASP.NET_Meeting_11.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Meeting_11.ViewModel
{
    public class GoodIndexViewModel
    {
        public IPagedList<Good> Goods { get; set; }
        public SelectList Categories { get; set; }
    }
}