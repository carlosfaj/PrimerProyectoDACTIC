using System;

public class Vehiculo
{
    public string Modelo { get; set; }
    public decimal PrecioPorDia { get; set; }

    public Vehiculo(string modelo, decimal precioPorDia)
    {
        Modelo = modelo;
        PrecioPorDia = precioPorDia;
    }

    // clase interna
    internal class Descuento
    {
        public static decimal AplicarDescuento(decimal precio, decimal porcentajeDescuento)
        {
            return precio - (precio * (porcentajeDescuento / 100));
        }
    }
}


