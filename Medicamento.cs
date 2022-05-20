using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Medicamento
    {
        public string Codigo_Medicamento { get; set; }
        public string Ingrediente_generico { get; set; }
        public string Laboratorio { get; set; }
        public string Enfermedades_para_Receta { get; set; }

    }
}