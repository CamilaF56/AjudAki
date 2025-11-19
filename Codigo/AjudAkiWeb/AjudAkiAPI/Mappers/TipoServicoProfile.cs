using AutoMapper;
using AjudAkiWeb.Models;
using Core.Models;

namespace AjudAkiWeb.Mappers
{
    public class TipoServicoProfile : Profile
    {
        public TipoServicoProfile()
        {
            CreateMap<TipoServicoViewModel, Tiposervico>().ReverseMap();
        }
    }
}
