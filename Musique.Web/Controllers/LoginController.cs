using Musique.BusinessLogic;
using Musique.BusinessLogic.Interfaces;
using Musique.Domain;
using Musique.Web.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using UDbTable = Musique.Domain.UDbTable;

namespace Musique.Web.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {

                UDbTable data = null;
                using (DBModels db = new DBModels())
                {
                    data = db.UDbTables.FirstOrDefault(u => u.Email == login.Credential && u.Password == login.Password);

                }
                if (data != null)
                {
                    FormsAuthentication.SetAuthCookie(login.Credential, true);
                    return RedirectToAction("Stream", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "L’adresse e-mail ou le mot de passe que vous avez entré n’est pas valide. Veuillez recommencer.");
                }
            }

            return View();
        }
    }
}