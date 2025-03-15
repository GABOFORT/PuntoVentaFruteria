using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.D_Categorias;

namespace Negocios
{
    public class N_Categorias
    {
        private D_Categorias objcd_Categorias = new D_Categorias();
        public List<Categorias> Listar()
        {
            return objcd_Categorias.Listar();
        }
        public int Registrar(Categorias obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombresCategorias == "")
            {
                Mensaje += "Es necesario el nombre completo de la Categoria\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Categorias.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Categorias obj, out string Mensaje)
        {         
            return objcd_Categorias.Editar(obj, out Mensaje);          
        }
        public bool Eliminar(Categorias obj, out string Mensaje)
        {
            return objcd_Categorias.Eliminar(obj, out Mensaje);
        }
    }
}
