﻿using Newtonsoft.Json;
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
        dimacodevEntities db = new dimacodevEntities();
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
            List<ColaboradorViewModel> colabList = db.colaboradors.Where(x=>x.cargo!=null).Select(x => new ColaboradorViewModel
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
            colaborador model = db.colaboradors.Where(x => x.run == run).SingleOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

    }
}