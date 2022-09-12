using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using DAL.Context;


namespace BLL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        BilgeHotelContext db = new BilgeHotelContext();
        public string Create(T model)
        {
            string result = "";
            try
            {
                db.Set(typeof(T)).Add(model);
                db.SaveChanges();
                result = $"Veri Kaydedildi";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(deleted);
                db.SaveChanges();
                return "Veri Silindi";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public T FindById(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);

        }

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return " Veri Başarıyla Güncellendi ";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
