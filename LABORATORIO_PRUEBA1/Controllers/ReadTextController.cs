using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text; //Este permite utilizar Encoding (Linea 27)

namespace FileUploadDemo.Controllers
{
    public class ReadTextController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
        //Recibo los datos de FileUploadController
        [HttpPost]
        public ActionResult Read(string filename)
        {
            var FileVirtualPath = "~/Archivos/" + filename;
            System.IO.StreamReader Leer = new System.IO.StreamReader("TxtName");
            string lector = "a";
            while (!Leer.EndOfStream)
            {
                lector = Leer.ReadLine();
            }
            byte[] bytes = Encoding.ASCII.GetBytes(lector);
            int result = BitConverter.ToInt32(bytes, 0);
            //Result es el trexto ya en codigo ascii
            return Redirect("/Album/Show/");
           
        }

    }
}
