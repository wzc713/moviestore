using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStoreProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index(string genal)
        {
            return "string is"+genal;
        }

    }
}
