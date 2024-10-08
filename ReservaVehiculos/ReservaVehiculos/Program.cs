class Program
{
    static void Main(string[] args)
    {
        Vehiculo vehiculo = new Vehiculo("Nissan Skyline GTR r35", 500.00m);

        // descuento de x0.10
        decimal porcentajeDescuento = 10m;
        int diasReserva = 5;

        // info del vehicuko
        Console.WriteLine(vehiculo.MostrarInformacion());

        // costo inicial de la reserva
        decimal costoTotal = CalcularReserva.CalcularCostoTotal(vehiculo, diasReserva, porcentajeDescuento);

        // costo total de la reserva
        Console.WriteLine($"El costo total por {diasReserva} días es: {costoTotal:C}");
    }
}
