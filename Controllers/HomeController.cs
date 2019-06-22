using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A.H.M.O._2018.Models;


namespace A.H.M.O._2018.Controllers
{
    public class HomeController : Controller
    {
        private HorasMedicasOnlineEntities1 db = new HorasMedicasOnlineEntities1();

        [HttpGet]
        public ActionResult Index(int? Especialidad)
        {


            //necesitamos mostrar todas las especialidades que hay registradas en la BD.
            List<Especialidad> lEspecialidad = new List<Especialidad>();
            lEspecialidad = db.Especialidad.ToList();
            ViewBag.listaEspecialidad = lEspecialidad;

            //necesitamos mostrar todos los doctores que hay registrados en la BD.
            List<Doctor> lDoctor = new List<Doctor>();
            if (Especialidad.HasValue)
            {
                lDoctor = db.Doctor.Where(d => d.IdE == Especialidad).ToList();
            }
            else
            {
                lDoctor = db.Doctor.ToList();
            }

            ViewBag.listaDoctor = lDoctor;
            return View();
        }


        [HttpGet]
        public  ActionResult GetEvents(int doctor)
        {
            List<MyAgenda> agenda = new List<MyAgenda>();
            foreach ( var evento in db.Agenda.Where(x=>x.IdD == doctor).ToList()) {
                int d = evento.Fecha.Value.Day;
                int m = evento.Fecha.Value.Month;

                string mes = (m < 10) ? "0" + evento.Fecha.Value.Month.ToString() : evento.Fecha.Value.Month.ToString();
                string dia = (d < 10) ? "0" + evento.Fecha.Value.Day.ToString() : evento.Fecha.Value.Day.ToString();

                string horaIni = (evento.HoraInicio.Value.Hours < 10) ? "0" + evento.HoraInicio.Value.Hours.ToString() : evento.HoraInicio.Value.Hours.ToString();
                string minutoIni = (evento.HoraInicio.Value.Minutes < 10) ? "0" + evento.HoraInicio.Value.Minutes.ToString() : evento.HoraInicio.Value.Minutes.ToString();

                string horaTer = (evento.HoraTermino.Value.Hours < 10) ? "0" + evento.HoraTermino.Value.Hours.ToString() : evento.HoraTermino.Value.Hours.ToString();
                string minutoTer = (evento.HoraTermino.Value.Minutes < 10) ? "0" + evento.HoraTermino.Value.Minutes.ToString() : evento.HoraTermino.Value.Minutes.ToString();



                string fecha = evento.Fecha.Value.Year + "-" + mes + "-" + dia;
                agenda.Add(
                    new MyAgenda()
                    {
                        title = "evento",
                        start =  fecha+ "T" + horaIni + ":" + minutoIni + ":00",
                        end =    fecha +"T" + horaTer+":"+ minutoTer +":00"

                    }
                    );
            }
            return Json(agenda,JsonRequestBehavior.AllowGet); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

               
    }
}

class MyAgenda
{
    public string title;
    public string start;
    public string end;


}