using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestPlantilla.Models;

namespace TestPlantilla.Controllers
{
    public class HomeController : Controller
    {
        dimacodevEntities1 db = new dimacodevEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Colaborador()
        {
            ViewBag.Title = "Colaboradores";
            return View();
        }

        public ActionResult HojaRuta()
        {
            return View();
        }

        public JsonResult GetColaboradorList()
        {
            List<ColaboradorViewModel> colabList = db.colaborador.Where(x => x.activo == true).Select(x => new ColaboradorViewModel
            {
                run = x.run,
                rut = x.rut,
                nombre = x.nombre,
                apellidoPaterno = x.apellidoPaterno,
                apellidoMaterno = x.apellidoMaterno,
                edad = x.edad,
                cargo = x.cargo,
                telefono = x.telefono,
                valorHoraExtra = x.valorHoraExtra
            }).ToList();
            return Json(colabList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetColaboradorByRun(int run)
        {
            colaborador model = db.colaborador.Where(x => x.run == run).SingleOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GuardarColaboradorInDatabase(ColaboradorViewModel model)
        {
            var result = false;
            try
            {
                colaborador colab = db.colaborador.Where(x => x.run == model.run).SingleOrDefault();
                string value = string.Empty;
                if (colab != null)
                {
                    colaborador col = db.colaborador.SingleOrDefault(s => s.run == model.run);


                    col.apellidoPaterno = model.apellidoPaterno;
                    col.apellidoMaterno = model.apellidoMaterno;
                    col.edad = model.edad;
                    col.cargo = model.cargo;
                    col.telefono = model.telefono;
                    col.valorHoraExtra = model.valorHoraExtra;
                    db.SaveChanges();
                    result = true;
                }
                else
                {
                    colaborador col = new colaborador();
                    col.run = model.run;
                    col.rut = model.rut;
                    col.nombre = model.nombre;
                    col.apellidoPaterno = model.apellidoPaterno;
                    col.apellidoMaterno = model.apellidoMaterno;
                    col.edad = model.edad;
                    col.cargo = model.cargo;
                    col.telefono = model.telefono;
                    col.valorHoraExtra = model.valorHoraExtra;
                    db.colaborador.Add(col);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BorrarRegistroColaborador(int run)
        {
            bool result = false;
            colaborador colab = db.colaborador.SingleOrDefault(x => x.activo == true && x.run == run);
            if (colab != null)
            {
                colab.activo = false;
                db.SaveChanges();
                result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}