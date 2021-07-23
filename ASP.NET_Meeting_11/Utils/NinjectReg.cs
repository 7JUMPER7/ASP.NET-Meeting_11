using ASP.NET_Meeting_11.DAL;
using ASP.NET_Meeting_11.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Meeting_11.Utils
{
    public class NinjectReg : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Good>>().To<GoodsRepository>();
            Bind<GoodsContext>().To<GoodsContext>();
        }
    }
}