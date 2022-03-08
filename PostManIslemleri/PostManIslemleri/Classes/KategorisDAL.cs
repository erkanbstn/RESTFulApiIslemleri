using PostManIslemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostManIslemleri.Classes
{
    public class KategorisDAL
    {
        UrunSatisDBEntities db = new UrunSatisDBEntities();
        public IEnumerable<TKategori> GetAllKategoris()
        {
            return db.TKategori;
        }
        public TKategori GetKategorisByID(int id)
        {
            return db.TKategori.Find(id);
        }
        public TKategori CreateKategori(TKategori t)
        {
            db.TKategori.Add(t);
            db.SaveChanges();
            return t;
        }
        public TKategori UpdateKategori(int id, TKategori t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return t;
        }
        public void DeleteKategori(int id)
        {
            db.TKategori.Remove(db.TKategori.Find(id));
            db.SaveChanges();
        }
    }
}