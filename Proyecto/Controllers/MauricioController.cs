using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Data;
using SampleMvcApp.Models.Mauricio;

namespace SampleMvcApp.Controllers
{
    public class MauricioController : Controller
    {
        public ActionResult Index()
        {
            Producto p = new Producto(3, "Producto 4", "Descripcion 4", 1000, new Categoria("Categoria 1"), false, 0);
            p.Eliminar();
            DataBase.Query s = new DataBase.Query();
            List<BitacoraBorrado> lista = s.ConsultarBitacoras();
            int a = 0;
            return View();
        }
        public ActionResult Familia()
        {
            ViewBag.Message = "Your application description page.";
            Familia familia = new Familia();
            Consulta consulta = new Consulta(familia.ConsultarDataBase());
            return View(consulta);
        }
        public ActionResult Categoria()
        {
            ViewBag.Message = "Your application description page.";
            Categoria categoria = new Categoria();
            Consulta consulta = new Consulta(categoria.ConsultarDataBase());
            return View(consulta);
        }
        public ActionResult FamiliasAgregar()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult CategoriasAgregar()
        {
            ViewBag.Message = "Your application description page.";
            Familia familia = new Familia();
            Consulta consulta = new Consulta(familia.ConsultarDataBase());
            return View(consulta);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult GuardarFamilia(FormCollection form)
        {
            var nombre = form["txtNombre"];
            var descripcion = form["txtDescripcion"];
            Models.Mauricio.Familia familia = new Models.Mauricio.Familia(nombre, descripcion, false);
            //if (!familia.Existe())
            //{
            familia.AgregarDataBase();
            return View("Index");
            //}
        }

        public ActionResult GuardarCategoria(FormCollection form)
        {
            var familia = form["cmbFamilias"];
            var nombre = form["txtNombre"];
            var descripcion = form["txtDescripcion"];
            Models.Mauricio.Categoria categoria = new Models.Mauricio.Categoria(nombre, descripcion, new Models.Mauricio.Familia(familia, false), false);
            if (!categoria.Existe())
            {
                categoria.AgregarDataBase();
            }
            return View("Index");
        }

        //muestra la ventana 
        public ActionResult ProductosAgregar()
        {
            Models.Mauricio.Categoria cat = new Categoria();
            List<Categoria> lisC = cat.ConsultarDataBase();
            var model = lisC;
            return View(model);
        }

        //agrega
        [HttpPost]
        public ActionResult ProductosAgregar(FormCollection form)
        {
            try
            {
                var cod = int.Parse(form["txtCod"]);
                var pre = int.Parse(form["txtPrecio"]);
                var categoria = form["cmbCategorias"];
                Models.Mauricio.Categoria cat = new Categoria(categoria);
                var nombre = form["txtNombre"];
                var descripcion = form["txtDescripcion"];
                Models.Mauricio.Producto prod = new Producto(cod, nombre, descripcion, pre, cat, false, 0);
                var res = prod.AgregarDataBase(0);
                return RedirectToAction("Producto");
            }
            catch
            {
                return RedirectToAction("Producto");
            }

        }

        public ActionResult ServiciosAgregar()
        {
            return View();
        }
        //agrega
        [HttpPost]
        public ActionResult ServiciosAgregar(FormCollection form)
        {
            try
            {
                var cod = int.Parse(form["txtCod"]);
                var pre = int.Parse(form["txtPrecio"]);
                var nombre = form["txtNombre"];
                var descripcion = form["txtDescripcion"];
                Models.Mauricio.Servicio ser = new Servicio(cod, nombre, descripcion, pre, false);
                ser.AgregarDataBase();
                return RedirectToAction("Servicio");
            }
            catch { return RedirectToAction("Servicio"); }
        }
        //muestra la ventana 
        public ActionResult Inventario()
        {
            return View();
        }
        //muestra la ventana 
        public ActionResult Producto()
        {
            Models.Mauricio.Producto prod = new Producto();
            List<Models.Mauricio.Producto> list = prod.ConsultarDataBase();
            var model = list;
            return View(model);
        }
        //muestra la ventana 
        public ActionResult Servicio()
        {
            Models.Mauricio.Servicio ser = new Servicio();
            List<Models.Mauricio.Servicio> list = ser.ConsultarDataBase();
            var model = list;
            return View(model);
        }

        public ActionResult ProductoEliminar(int id)
        {
            try
            {
                Models.Mauricio.Producto prod = new Producto(id, "");
                prod.Eliminar();
                return RedirectToAction("Producto");
            }
            catch { return RedirectToAction("Producto"); }

        }

        public ActionResult ServicioEliminar(int id)
        {
            try
            {
                Models.Mauricio.Servicio ser = new Servicio(id, "");
                ser.Eliminar();
                return RedirectToAction("Servicio");
            }
            catch { return RedirectToAction("Servicio"); }

        }

        public ActionResult FamiliaEliminar(string nombre)
        {

            Models.Mauricio.Familia fam = new Familia(nombre);
            fam.Eliminar();
            return RedirectToAction("Familia");
        }

        public ActionResult CategoriaEliminar(string nombre)
        {

            Models.Mauricio.Categoria cat = new Categoria(nombre);
            cat.Eliminar();
            return RedirectToAction("Categoria");
        }
    }
}
