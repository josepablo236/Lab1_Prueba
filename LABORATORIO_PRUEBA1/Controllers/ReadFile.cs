using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUploadDemo.Controllers
{
    public class ReadFile : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
        public ActionResult ReadFiletext(string filename)
        {
            var FileVirtualPath = "~/Archivos/" + filename;
            System.IO.StreamReader Leer = new System.IO.StreamReader("TxtName");

            while (!Leer.EndOfStream)
            {
                string lector = Leer.ReadToEnd();
            }
            return Redirect("/Album/Show/");
        }
    }
}
