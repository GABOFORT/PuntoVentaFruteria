using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class N_Productos
    {
        private D_Productos objcd_Productos = new D_Productos();
        public List<Productos> Listar()
        {
            return objcd_Productos.Listar();
        }
        public int Registrar(Productos obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.codigos == "")
            {
                Mensaje += "Es necesario el Codigo\n";
            }
            if (obj.nombresProductos == "")
            {
                Mensaje += "Es necesario el nombre completo del Producto\n";
            }
            if (obj.descripciones == "")
            {
                Mensaje += "Es necesario el nombre completo del Descripcion\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Productos.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Productos obj, out string Mensaje)
        {
            return objcd_Productos.Editar(obj, out Mensaje);
        }
        public bool Eliminar(Productos obj, out string Mensaje)
        {
            return objcd_Productos.Eliminar(obj, out Mensaje);
        }
    }
}
