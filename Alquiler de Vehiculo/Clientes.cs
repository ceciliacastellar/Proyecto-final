using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Vehiculo
{
     public class Clientes:Lista_Reservas
    {
        public Clientes(int cod_Cliente, int ced_Cliente, string Nombre_Cliente, string direccion, int telefono)
        {
            this.cod_Cliente = cod_Cliente;
            this.ced_Cliente = ced_Cliente;
            this.Nombre_Cliente = Nombre_Cliente;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
        public int cod_Cliente { get; private set; }
        public int ced_Cliente { get; private set; }
        public string Nombre_Cliente { get; private set; }
        public String Direccion { get; private set; }
        public int Telefono{ get; private set; }

    }
}
