using AjudAkiWeb.Models;
using AutoMapper;
using Core.Models;

namespace Mappers
{
    public class AssinaturaProfile : Profile
    {
        public AssinaturaProfile()
        {
            CreateMap<AssinaturaViewModel, Assinatura>().ReverseMap();
        }
    }
}
