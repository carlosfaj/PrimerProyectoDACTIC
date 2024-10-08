using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeVehiculos
{
    public class Vehiculos
    {
        public string Modelo { get; set; }

        public decimal PrecioPorDia { get; set; }
    }
    internal class Descuento
    {
        public static decimal AplicarDescuento(decimal precio, decimal porcentajeDescuento)
        {
            return precio - (precio * (porcentajeDescuento / 100));
        }
    }
}