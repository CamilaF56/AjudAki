using AjudAkiWeb.Models;
using AutoMapper;
using Core.Models;

namespace AjudAkiWeb.Mappers
{
    public class PagarAssinaturaProfile : Profile
    {
        public PagarAssinaturaProfile()
        {
            CreateMap<PagarAssinaturaViewModel, Pagamentoassinatura>().ReverseMap();
        }
    }
}
