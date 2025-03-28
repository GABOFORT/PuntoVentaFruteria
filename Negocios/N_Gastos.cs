using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Gastos
    {
        private D_Gastos objcd_Gastos = new D_Gastos();
        public List<Gastos> Listar()
        {
            return objcd_Gastos.Listar();
        }
        public int GuardarGastos(Gastos obj, out string Mensaje)
        {
           return objcd_Gastos.GuardarGastos(obj, out Mensaje);
        }
        public bool EliminarGastos(Gastos obj, out string Mensaje)
        {
            return objcd_Gastos.EliminarGastos(obj, out Mensaje);
        }
        public bool EditarGastos(Gastos obj, out string Mensaje)
        {
            return objcd_Gastos.EditarGastos(obj, out Mensaje);
        }
        public List<Gastos> ReporteGastos(string fechaInicio, string fechaFin)
        {
            return objcd_Gastos.ReporteGastos(fechaInicio, fechaFin);
        }
    }
}
