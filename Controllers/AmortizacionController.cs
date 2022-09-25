using Microsoft.AspNetCore.Mvc;
using TablaAmortizacionApi.DTOs;
using TablaAmortizacionApi.Entidades;
using TablaAmortizacionApi.Logica;

namespace TablaAmortizacionApi.Controllers
{
    [ApiController]
    [Route("api/amortizacion")]
    public class AmortizacionController : ControllerBase
    {
        private readonly ICalculoAmortizacion calculoAmortizacion;

        public AmortizacionController(ICalculoAmortizacion calculoAmortizacion )
        {
            this.calculoAmortizacion = calculoAmortizacion;
        }

        [HttpPost]

        public ActionResult<List<Prestamo>> Post(PrestamosCreacionDTO prestamosDTO)
        {
            try
            {
                List<Prestamo> list = new List<Prestamo>();

                list = calculoAmortizacion.Amortizacion(prestamosDTO.Periodo, prestamosDTO.Deuda, prestamosDTO.TasaInteres);

                return list;
            }
            catch (Exception)
            {

                throw;
            }
   
        }
    }
}
