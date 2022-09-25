using AutoMapper;
using TablaAmortizacionApi.DTOs;
using TablaAmortizacionApi.Entidades;

namespace TablaAmortizacionApi.Utilidades
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<PrestamosCreacionDTO, Prestamo>();
        }
    }
}
