using asistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asistencia.Controllers
{
    public class AsistenciaController : Controller
    {
        // GET: Asistencia
        public ActionResult Index()
        {
            //condicion si existe un ID de usuario al hacer login
            if (Session["Id"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            List<AsistenciaCLS> listaAsistencia = new List<AsistenciaCLS>();
            using(var bd = new asistenciaEntities())
            {
                listaAsistencia = (from historial in bd.asistencia
                                   join usuario in bd.usuarios
                                   on historial.USU_ID equals usuario.USU_ID
                                   orderby historial.ASI_FECHA descending
                                   select new AsistenciaCLS
                                   {
                                       idAsistencia = historial.ASI_ID,
                                       empleadoAsistencia = usuario.USU_NOMBRES,
                                       fecha = (DateTime) historial.ASI_FECHA,
                                       horaIngreso = historial.ASI_HORA_INGRESO,
                                       horaSalida = historial.ASI_HORA_SALIDA,
                                       estadoAsistencia = (int) historial.ASI_ESTADO,
                                       observacion = historial.ASI_OBSERVACION,
                                       atrasos = (int) historial.ASI_ATRASO
                                   }).ToList();
            }
            return View(listaAsistencia);
        }

        public ActionResult Filtrar(AsistenciaCLS oAsistenciaCLS)
        {
            string termino = oAsistenciaCLS.termino;
            List<AsistenciaCLS> listaAsistencia = new List<AsistenciaCLS>();

            using (var bd = new asistenciaEntities())
            {
                if (termino == null)
                {
                    listaAsistencia = (from historial in bd.asistencia
                                       join usuario in bd.usuarios
                                       on historial.USU_ID equals usuario.USU_ID
                                       select new AsistenciaCLS
                                       {
                                           idAsistencia = historial.ASI_ID,
                                           empleadoAsistencia = usuario.USU_NOMBRES,
                                           fecha = (DateTime)historial.ASI_FECHA,
                                           horaIngreso = historial.ASI_HORA_INGRESO,
                                           horaSalida = historial.ASI_HORA_SALIDA,
                                           estadoAsistencia = (int)historial.ASI_ESTADO,
                                           observacion = historial.ASI_OBSERVACION
                                       }).ToList();
                }
                else
                {
                    listaAsistencia = (from historial in bd.asistencia
                                       join usuario in bd.usuarios
                                       on historial.USU_ID equals usuario.USU_ID
                                       where usuario.USU_NOMBRES.Contains(termino)
                                       select new AsistenciaCLS
                                       {
                                           idAsistencia = historial.ASI_ID,
                                           empleadoAsistencia = usuario.USU_NOMBRES,
                                           fecha = (DateTime)historial.ASI_FECHA,
                                           horaIngreso = historial.ASI_HORA_INGRESO,
                                           horaSalida = historial.ASI_HORA_SALIDA,
                                           estadoAsistencia = (int)historial.ASI_ESTADO,
                                           observacion = historial.ASI_OBSERVACION
                                       }).ToList();
                }

            }

            return PartialView("_tablaAsistencia", listaAsistencia);
        }

        //Editar justificación
        public JsonResult recuperarDatos(int id)
        {
            AsistenciaCLS oAsistenciaCLS = new AsistenciaCLS();
            try
            {
                using (var bd = new asistenciaEntities())
                {
                    Models.asistencia oAsistencia = bd.asistencia.Where(p => p.ASI_ID == id).First();
                    oAsistenciaCLS.observacion = oAsistencia.ASI_OBSERVACION;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return Json(oAsistenciaCLS, JsonRequestBehavior.AllowGet);
        }

    }
}