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
            //Convierte a codigo Ascii
            byte[] bytes = Encoding.ASCII.GetBytes(lector);
            int result = BitConverter.ToInt32(bytes, 0);
            //Result es el trexto ya en codigo Asciii
            int[] letras = new int[27]; //Esta matriz va a guardar cuantas veces se repite
            string[] letras_binary = new string[27]; //Esta matriz va a guardar la letra en binario
            foreach (int bite in bytes)
            {
                letras[bite]++;
                letras_binary[bite] = bite.ToString(); //Convierte la letra en binario
            }

            return "/";
        }


    }
}
