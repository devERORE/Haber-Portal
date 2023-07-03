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
    public class AccountController : Controller
    {
        
        #region Kullanıcı
        public readonly IKullanıcıRepository _kullanıcıRepository;
        public AccountController(IKullanıcıRepository kullanıcıRepository)
        {
            _kullanıcıRepository = kullanıcıRepository; 

        }
        #endregion
        [HttpGet]
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanıcı kullanıcı)
        {
            var KullanıcıVarmi = _kullanıcıRepository.GetMany(x=> x.Email ==kullanıcı.Email && x.Sifre == kullanıcı.Sifre && x.Aktif == true).SingleOrDefault();
            if (KullanıcıVarmi != null)
            {
                if(KullanıcıVarmi.Rol.RolAdi=="Admin")
                {
                    Session["KullanıcıEmail"] = KullanıcıVarmi.Email;
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Mesaj = "Yetkisiz Kullanıcı";
                return View();
            }
            ViewBag.Mesaj = "Kullanıcı bulunamadı";

            return View();
        }
    }
}