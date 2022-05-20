using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Historial_Paciente
    {
        public  string Id_consulta { get; set; }
        public  string Nit_Paciente  { get; set; }
        public  DateTime Fecha_hora_consulta { get; set; }
        public  string Hora_Inicio { get; set; }
        public  string Temperatura { get; set; }
        public  string Presion { get; set; }
        public  List<Sintoma> sintomas { get; set; }
        public static string Diagnostico { get; set; }
        public  string Tratamiento { get; set; }
        public  string Receta { get; set; }
        public  string Proxima_visita { get; set; }
        public  string Costo_Consulta { get; set; }
       


    }
}