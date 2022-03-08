using PostManIslemleri.Classes;
using PostManIslemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PostManIslemleri.Controllers
{
    public class KategorisController : ApiController
    {
        KategorisDAL db = new KategorisDAL();

        [Route("api/Kategoris/Liste")]
        [HttpGet]
        public IEnumerable<TKategori> Get()
        {
            return db.GetAllKategoris();
        }
        [Route("api/Kategoris/Liste")]
        [HttpGet]
        public TKategori Get(int id)
        {
            return db.GetKategorisByID(id);
        }
        [Route("api/Kategoris/Ekle")]
        [HttpPost]
        public TKategori Post(TKategori t)
        {
            return db.CreateKategori(t);
        }
        [Route("api/Kategoris/Guncelle/id")]
        [HttpPut]
        public TKategori Put(int id, TKategori t)
        {
            return db.UpdateKategori(id, t);
        }
        [Route("api/Kategori/id")]
        [HttpDelete]
        public void Delete(int id)
        {
            db.DeleteKategori(id);
        }
    }
}
