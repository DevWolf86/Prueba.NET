using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.NET.Models
{
    public class Listado
    {
        public List<Datos> Datas { get; set; }
        public List<Cancelaciones> Cancelaciones { get; set; }
        public List<Datos_GetAll_Result> Datos_GetAll_Results { get; set; }
    }
}