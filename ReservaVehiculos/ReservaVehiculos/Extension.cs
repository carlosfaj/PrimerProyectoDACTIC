using System.Runtime.CompilerServices;

public static class Extension
{
    public static string MostrarInformacion(this Vehiculo vehiculo)
    {
        return $"Modelo: {vehiculo.Modelo}, Precio por Día: {vehiculo.PrecioPorDia:C}";
    }
}
