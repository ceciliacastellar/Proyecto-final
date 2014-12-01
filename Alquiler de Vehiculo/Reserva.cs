using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Vehiculo
{
     public class Reserva:Lista_Vehiculos
    {
         public Reserva(int cod_Reserva, DateTime fecha_salida, DateTime fecha_Entrega, float precio_Total,
             Boolean indicador_Entrega, float litros_Gasolina) 
         {
             this.Cod_Reserva = cod_Reserva;
             this.Fecha_Salida = fecha_salida;
             this.Fecha_Entrega = fecha_Entrega;
             this.Precio_Total = precio_Total;
             this.Indicador_Entrega = indicador_Entrega;
             this.Litros_Gasolina = litros_Gasolina;
         }
         public int Cod_Reserva { get; private set; }
         public DateTime Fecha_Salida { get; private set; }
         public DateTime Fecha_Entrada { get; private set; }
         public float Precio_Total { get; private set; }
         public Boolean Indicador_Entrega { get; private set; }
         public float Litros_Gasolina { get; private set; }
    }
    public Lista_Reservas Lista_Reservas
{

get
{

throw new System.NotImplementedException();
}
set
{
} 
}
}
