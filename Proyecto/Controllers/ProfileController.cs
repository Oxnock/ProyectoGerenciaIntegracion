using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Data;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class ProfileController : Controller
    {    

        // GET: Profile
        public ActionResult Index()
        {
            sql3283190Context context = HttpContext.RequestServices.GetService(typeof(sql3283190Context)) as sql3283190Context;
            HomeController.FormInicialFlag = true;
            return View(context.ObtenerPersona(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value));

            //return View();
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profile/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string command, ProfileModel profileModel, int id, IFormCollection collection)
        {
            sql3283190Context context = HttpContext.RequestServices.GetService(typeof(sql3283190Context)) as sql3283190Context;
            string correo = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            try
            {
                if (command == "submit")
                {
                    context.EditarUsuario(profileModel.Name, profileModel.FirstLastName, profileModel.SecondLastName, profileModel.PhoneNumber, correo);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FORMINICIAL(int id)
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FORMINICIAL(string command, ProfileModel profileModel ,int id, IFormCollection collection)
        {
            sql3283190Context context = HttpContext.RequestServices.GetService(typeof(sql3283190Context)) as sql3283190Context;
            string correo = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            try
            {
                if (command == "submit")
                {
                    context.InsertFormInicial(profileModel.Name, profileModel.FirstLastName, profileModel.SecondLastName, profileModel.PhoneNumber, profileModel.PersonID, profileModel.IDType, correo);
                }
                    



                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}