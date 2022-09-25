using System.ComponentModel.DataAnnotations;

namespace TablaAmortizacionApi.DTOs
{
    public class PrestamosCreacionDTO
    {
        [Required]
        public int Periodo { get; set; }
        [Required]
        public double Deuda { get; set; }
        [Required]
        public double TasaInteres { get; set; }
    }
}
