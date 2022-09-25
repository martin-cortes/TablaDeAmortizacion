using System.ComponentModel.DataAnnotations;

namespace TablaAmortizacionApi.Entidades
{
    public class Prestamo
    {
        [Required]
        public int Periodo { get; set; }
        [Required]
        public double Deuda { get; set; }
        [Required]
        public double TasaInteres { get; set; }

        public double Intereses { get; set; }

        public double Amortizacion { get; set; }

        public double Pago { get; set; }

        public double DeudaFinal { get; set; }


    }
}
 