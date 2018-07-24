using EncuestasPeru.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EncuestasPeru.Controllers
{
    public class CandidatoController : Controller
    {
        // GET: Candidato
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string search)
        {
            var data = new CandidatoLogic().ObtenerBusquedaCandidato(search);
            return View();
        }
    }
} 