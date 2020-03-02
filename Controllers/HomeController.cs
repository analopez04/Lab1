using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;

using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vervideos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Vervideos(string titulo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@titulo", titulo));
            BaseHelper.ejecutarConsulta("SELECT * FROM video WHERE titulo=@titulo", CommandType.Text, parametros);
        
            return View();
        }

        public ActionResult Agregarvideo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregarvideo(int idVideo, string titulo, int numReproducciones, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@numReproducciones", numReproducciones));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("INSERT INTO video VALUES (@idVideo, @titulo, @numReproducciones, @url)", CommandType.Text, parametros);

            return View("Mensaje");
        }

        public ActionResult Eliminarvideo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Eliminarvideo(string titulo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@titulo", titulo));
            BaseHelper.ejecutarSentencia("DELETE FROM video WHERE titulo=@titulo", CommandType.Text, parametros);
            return View();
           
        }

        public ActionResult Modificarvideo()
        {
            return View();
        }

        public ActionResult Modificarvideo(int idVideo, string titulo, int numReproducciones, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@numReproducciones", numReproducciones));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("UPDATE video SET idVideo=@idVideo, titulo=@titulo, numReproducciones=@numReproducciones,url=@url WHERE titulo=@titulo", CommandType.Text, parametros);
            return View();
        }

        public ActionResult Mensaje()
        {
            return View();
        }

       
    }
}
