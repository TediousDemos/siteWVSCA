using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace siteWVSCA.Controllers
{
    public class JsonStringResult : ContentResult
    {
        // GET: JSON
        public JsonResult fnname()
        {
            string variablename = "{name:'jack',message:'success'}";
            return Json(variablename, JsonRequestBehavior.AllowGet);
        }

        private JsonResult Json(string variablename, JsonRequestBehavior allowGet)
        {
            throw new NotImplementedException();
        }
    }
}