using NCMA.Data;
using NCMA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCMA.Web.Api.Controllers
{
    public class DojosController : Controller
    {
        private readonly DojoService dojoSvc;

        public DojosController()
        {
            dojoSvc = new DojoService();
        }

        [HttpGet]
        [Route("/api/Dojos/")]
        public IEnumerable<dojo> GetDojos()
        {
            return dojoSvc.GetDojos();
        }
    }
}