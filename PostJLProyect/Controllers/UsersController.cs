using PostJLProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostJLProyect.Controllers
{
    public class UsersController : Controller
    {

        RepositoryUser repo;

        public UsersController()
        {

            this.repo = new RepositoryUser();

        }

        public ActionResult Index()
        {
            return View(this.repo.GetUsers());
        }

        public ActionResult Error()
        {
            return View();
        }

        [HandleError(View = "Error")]
        public ActionResult Excep()
        {
            throw new Exception("ErrorExcept");
        }


        public ActionResult Create()
        {

            return View();

        }

        [HttpPost]
        [EsSegura]
        public ActionResult Create(String name, String surname, String pw)
        {
            this.repo.CreateUser(name,surname,pw);
            return RedirectToAction("Index", "Users");

        }

        public ActionResult Delete(int id)
        {
            this.repo.EliminarUser(id);
            return RedirectToAction("Index");
        }
        
        [OutputCache(Duration = 10, VaryByParam = "none")]
        [AllowJsonGet]
        public ActionResult GetGanador()
        {
            int res = this.repo.GetOdd();
            return new JsonResult() { Data = res };
        }

        [HttpPost]
        [Route("Delete/{id}")]
        public ActionResult EliminarUser(int id)
        {
            this.repo.EliminarUser(id);
            return RedirectToAction("Index", "Users");
        }

    }
}