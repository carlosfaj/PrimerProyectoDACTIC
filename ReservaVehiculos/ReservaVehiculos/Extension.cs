using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace ReservaDeVehiculos
{
    public static class Extension
    {
        public static string MostrarInformacion(this Vehiculos vehiculos)
        {
            return $"Modelo: {vehiculos.Modelo}, Precio por Dia: {vehiculos.PrecioPorDia:C}";
        }

    }
}