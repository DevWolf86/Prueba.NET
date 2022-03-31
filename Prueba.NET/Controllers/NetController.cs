using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbPruebaNet;
using Prueba.NET.Models;

namespace Prueba.NET.Controllers
{
    public class Result
    {
        public string CC { get; set; }
        public string SKU { get; set; }
        public string F12 { get; set; }
        public string OC { get; set; }
        public string ESTADO { get; set; }


    }

    public class ResultModel
    {
      public string OC { get; set; }
      public string PRECIO_DESPACHO { get; set; }
      public string MONTO_TOTAL_LINEA { get; set; }
      public string SKU_LINEA { get; set; }
      public string F12 { get; set; }
      public string TIPO_ABASTECIMIENTO { get; set; }
      public string DUP_OC { get; set; }
      public string DUP_F12 { get; set; }
      public string ESTADO_LINEA { get; set; }
      public string ESTADO_ORDEN_OMS { get; set; }
      public string ESTADO_CD { get; set; }
    }
    public class NetController : Controller
    {
        // GET: Net
        PruebaEntities db = new PruebaEntities();

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta()
        {
            //PruebaEntities newdata = new PruebaEntities();
            //return View(newdata.Datos_GetAll_New(""));
            return View();
        }

        [HttpPost]
        public ActionResult Consulta(string documento)
        {
            //string documento = FormDocs["documento"];

            //var lista = db.Datos.Where(x => x.CC == documento).ToList();
            //Result result = new Result();
            //result.CC = lista[0].CC;
            //result.F12 = lista[0].F12;
            //result.SKU = lista[0].SKU;
            //result.OC = lista[0].OC;
            //result.ESTADO = lista[0].ESTADO;

            
            PruebaEntities newdata = new PruebaEntities();
            return View(newdata.Datos_GetAll_New(documento).AsEnumerable());


          

        }   
    }
}