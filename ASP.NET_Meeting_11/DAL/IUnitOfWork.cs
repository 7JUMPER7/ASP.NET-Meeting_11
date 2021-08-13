using ASP.NET_Meeting_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Meeting_11.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Good> Goods { get; }
        void Save();
    }
}
