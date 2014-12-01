using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Vehiculo
{
    public class Garaje:Lista_Vehiculos
    {
        public Garaje(int cod_Garaje; string nombre_Garaje)
    {
        this.Cod_Garaje = cod_Garaje;
        this.Nombre_Garaje = nombre_Garaje;
    }

    public int Cod_Garaje{ get; private set;}
    public string Nombre_Garaje{get; private set;}

    }
}
