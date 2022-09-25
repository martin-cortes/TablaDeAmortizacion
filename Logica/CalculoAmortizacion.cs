using TablaAmortizacionApi.Entidades;

namespace TablaAmortizacionApi.Logica
{
    public class CalculoAmortizacion: ICalculoAmortizacion
    {
        public List<Prestamo> Amortizacion(int periodo, double deuda, double tasaInteres)
        {
            List<Prestamo> final = new List<Prestamo>();

            double constante = deuda;
            int contadorCuota = 1;
            double i = deuda;


            while (i != 0 && i > 0)
            {
                Prestamo prestamos = new Prestamo();

                prestamos.Periodo = contadorCuota;
                prestamos.Deuda = deuda;
                prestamos.TasaInteres = tasaInteres;
                prestamos.Intereses = (deuda * tasaInteres) / periodo;
                prestamos.Amortizacion = constante / periodo;
                prestamos.Pago = prestamos.Intereses + prestamos.Amortizacion;
                prestamos.DeudaFinal = (deuda + prestamos.Intereses) - prestamos.Pago;
                if (prestamos.DeudaFinal < 0) { prestamos.DeudaFinal = 0; }

                contadorCuota++;
                deuda = prestamos.DeudaFinal;
                i = prestamos.DeudaFinal;


                final.Add(prestamos);



            }

            return final;
        }

    }
}
