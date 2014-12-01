using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Vehiculo
{
   public class Vehiculo
    {
        public Vehiculo (string matricula; string modelo; string color; string marca; float precio_alquiler)
    {
        this.Matricula= matricula;
        this.Modelo = modelo;
        this.Color= color;
        this.Marca= marca;
        this.Precio_Alquiler_Dia=precio_alquiler;

    }

    public string Matricula {get; private set;}
    public string Modelo {get; private set;}
    public string Color {get; private set;}
    public string Marca {get; private set;}
    public float Precio_Alquiler_Dia {get; private set;}
    }
public Lista_Vehiculos Lista_Vehiculos
{
get{
throw new system.NotImplemetedException();
}

set{
} 
}
}
