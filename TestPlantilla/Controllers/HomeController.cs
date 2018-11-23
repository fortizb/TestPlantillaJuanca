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

        public ActionResult Vehiculos()
        {
            ViewBag.Title = "Vehiculos";
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
                    col.activo = true;
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
                    col.activo = true;
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

        //hola que hace
        public JsonResult GetVehiculoList()
        {
            List<VehiculoViewModel> vehiculoList = db.vehiculo.Where(x => x.activo == true).Select(x => new VehiculoViewModel
            {
                patente = x.patente,
                marca = x.marca,
                modelo = x.modelo,
                color = x.color,
                velocidadPromedio = x.velocidadPromedio,
                rendimiento = x.rendimiento,
                capacidadCarga = x.capacidadCarga,
                descripcion = x.descripcion,
 
            }).ToList();
            return Json(vehiculoList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetVehiculoByPatente(string patente)
        {
            vehiculo model = db.vehiculo.Where(x => x.patente == patente).SingleOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GuardarVehiculoInDatabase(VehiculoViewModel model)
        {
            var result = false;
            try
            {
                vehiculo ve = db.vehiculo.Where(x => x.patente == model.patente).SingleOrDefault();
                string value = string.Empty;
                if (ve != null)
                {
                    vehiculo veh = db.vehiculo.SingleOrDefault(s => s.patente == model.patente);

                    veh.patente = model.patente;
                    veh.marca = model.marca;
                    veh.modelo = model.modelo;
                    veh.color = model.color;
                    veh.velocidadPromedio = model.velocidadPromedio;
                    veh.rendimiento = model.rendimiento;
                    veh.capacidadCarga = model.capacidadCarga;
                    veh.descripcion = model.descripcion;
                    veh.activo = true;
                    db.SaveChanges();
                    result = true;
                }
                else
                {
                    vehiculo veh = new vehiculo();
                    veh.patente = model.patente;
                    veh.marca = model.marca;
                    veh.modelo = model.modelo;
                    veh.color = model.color;
                    veh.velocidadPromedio = model.velocidadPromedio;
                    veh.rendimiento = model.rendimiento;
                    veh.capacidadCarga = model.capacidadCarga;
                    veh.descripcion = model.descripcion;
                    veh.activo = true;
                    db.vehiculo.Add(veh);
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

        public JsonResult BorrarRegistroVehiculo(string patente)
        {
            bool result = false;
            vehiculo veh = db.vehiculo.SingleOrDefault(x => x.activo == true && x.patente == patente);
            if (veh != null)
            {
                veh.activo = false;
                db.SaveChanges();
                result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);

        }


    }
}