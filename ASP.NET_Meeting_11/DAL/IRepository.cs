using ASP.NET_Meeting_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ASP.NET_Meeting_11.DAL
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetList();
        IEnumerable<T> GetList(string include);
        T GetById(int id);

        void Delete(int id);
        void Delete(T entity);
        void Update(T entity);
        void Create(T entity);
        void Save();
        SelectList GetCategories(string dataValue, string dataText);
        SelectList GetCategories(string dataValue, string dataText, int selectedItem);
        Photo AddPhoto(Photo photo);
        void RemoveImagesOfGood(Good good);
    }
}
