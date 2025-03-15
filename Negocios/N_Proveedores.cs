using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Proveedores
    {
        private D_Proveedores objcd_proveedores = new D_Proveedores();
        public List<Proveedores> Listar()
        {
            return objcd_proveedores.Listar();
        }
        public int Registrar(Proveedores obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.clavesProveedores == "")
            {
                Mensaje += "Es necesario la clave del proveedor\n";
            }
            if (obj.nombresProveedores == "")
            {
                Mensaje += "Es necesario el nombre completo del proveedor\n";
            }
            if (obj.telefonos == "")
            {
                Mensaje += "Es necesario el telefono del proveedor\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_proveedores.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Proveedores obj, out string Mensaje)
        {
            return objcd_proveedores.Editar(obj, out Mensaje);
        }
        public bool Eliminar(Proveedores obj, out string Mensaje)
        {
            return objcd_proveedores.Eliminar(obj, out Mensaje);
        }
    }
}
