using Musique.BusinessLogic.DBModel;
using Musique.Domain;
using Musique.Domain.Entities.User;
using Musique.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDbTable = Musique.Domain.UDbTable;

namespace Musique.Web.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserRegister user)
        {
            UDbTable model = new UDbTable
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email
            };
            model.LastLogin = DateTime.Now;
            if (ModelState.IsValid)
            {

                using (DBModels db = new DBModels())
                {
                    if (db.UDbTables.Any(x => x.Username == model.Username))
                    {

                        return View("Index");
                    }
                    else
                    {

                        db.UDbTables.Add(model);
                        db.SaveChanges();
                    }
                }
            

            return RedirectToAction("Stream", "Home", user);
            }
            return View("Index");
        }

    }
}