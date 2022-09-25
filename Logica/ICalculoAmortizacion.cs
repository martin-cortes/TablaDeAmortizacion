using TablaAmortizacionApi.Entidades;

namespace TablaAmortizacionApi.Logica
{
    public interface ICalculoAmortizacion
    {
        List<Prestamo> Amortizacion(int periodo, double deuda, double tasaInteres);
    }
}
