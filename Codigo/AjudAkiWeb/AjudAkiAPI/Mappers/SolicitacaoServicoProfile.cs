using AutoMapper;
using Core.Models;

namespace AjudAkiAPI.Mappers
{
    public class SolicitacaoServicoProfile : Profile
    {
        public SolicitacaoServicoProfile()
        {
            CreateMap<Models.SolicitacaoServicoViewModel, Solicitacaoservico>().ReverseMap();
        }
    }
}
