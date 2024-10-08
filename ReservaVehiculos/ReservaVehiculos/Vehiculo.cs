using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVehiculos
{
    internal class Vehiculo
    {
        public string Modelo { get; set; }
        public decimal PrecioXDia { get; set; }
    }
    internal class Descuento
    {
        public static decimal AplicarDescuento(decimal precio, decimal porcentajeDescuento)
        {
            return precio - (precio * (porcentajeDescuento / 100));
        }
    }
}