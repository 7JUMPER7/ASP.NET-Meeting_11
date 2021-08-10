using ASP.NET_Meeting_11.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Meeting_11.Models
{
    public class GoodsRepository : IRepository<Good>
    {
        private readonly GoodsContext context;
        public GoodsRepository(GoodsContext context)
        {
            this.context = context;
        }


        public void Create(Good entity)
        {
            context.Goods.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Good buf = GetById(id);
            if (buf != null)
            {
                context.Goods.Remove(buf);
                context.SaveChanges();
            }
        }

        public void Delete(Good entity)
        {
            if (entity != null)
            {
                context.Goods.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Good GetById(int id)
        {
            return context.Goods.Find(id);
        }

        public SelectList GetCategories(string dataValue, string dataText, bool withAll = false)
        {
            var categories = context.Categories.ToList();
            if (withAll)
            {
                categories.Insert(0, new Category { Id = 0, CategoryName = "Все" });
            }
            return new SelectList(categories, dataValue, dataText);
        }

        public SelectList GetCategories(string dataValue, string dataText, int selectedItem)
        {
            return new SelectList(context.Categories, dataValue, dataText, selectedItem);
        }

        public IEnumerable<Good> GetList()
        {
            return context.Goods;
        }

        public IEnumerable<Good> GetList(string include)
        {
            return context.Goods.Include(include);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Good entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public Photo AddPhoto(Photo photo)
        {
            context.Photos.Add(photo);
            context.SaveChanges();
            return photo;
        }

        public void RemoveImagesOfGood(Good good)
        {
            context.Photos.RemoveRange(context.Photos.Where(p => p.GoodId == good.Id));
            context.SaveChanges();
        }
    }
}