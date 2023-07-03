using HaberSistemi.Core.Infrastucture;
using HaberSistemi.Core.Repository;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSistemi.Admin.Controllers
{
    public class KategoriController : Controller

    {
        
        #region Kategori
        private readonly IKategoriRepository _kategoriRepository;

        public KategoriController(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;

        }
        #endregion

        public ActionResult Index()

        {
            ;
            return View(_kategoriRepository.GetAll().ToList());

        }
        [HttpGet]

        public ActionResult Ekle()
        {

            
            return View(_kategoriRepository.GetAll().ToList());
        }
        [HttpPost]
        
        public JsonResult Ekle(Kategori kategori)
        {
            
            return Json(1, JsonRequestBehavior.AllowGet);
        }
    }
}