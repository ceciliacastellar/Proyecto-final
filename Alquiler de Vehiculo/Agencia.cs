using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Vehiculo
{
   public class Agencia:Lista_Reservas
    {
        public Agencia(int cod_Agencia, String nombre_Agencia) {

            this.cod_Agencia = cod_Agencia;
            this.Nombre_Agencia = nombre_Agencia;
        }
        public int cod_Agencia { get; private set; }
        public string Nombre_Agencia { get; private set; }
    }
}
