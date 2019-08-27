using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
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
   
        public ActionResult Read(string filename)
        {
            string path = Path.Combine(Server.MapPath("~/Archivos"), filename);
            System.IO.StreamReader Leer = new System.IO.StreamReader(path);
            string lector = "a";
            while (!Leer.EndOfStream)
            {
                lector = Leer.ReadLine();
            }
            byte[] bytes = Encoding.ASCII.GetBytes(lector);
            int result = BitConverter.ToInt32(bytes, 0);
            //Result es el trexto ya en codigo Asciii
            ViewBag.Message = result.ToString();
            return "/";
        }

    }
}
