using Ninject;
using OCManager.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCManager.Controllers
{
    public class OccurenceManagerController : Controller
    {
        [Inject]
        public IOccurenceBusinessService _occurenceBusinessService { get; set; }
        //
        // GET: /OccurenceManager/
        public ActionResult Index()
        {
           
            var res = _occurenceBusinessService.GetOccurencesList();

            return View();
        }
	}
}