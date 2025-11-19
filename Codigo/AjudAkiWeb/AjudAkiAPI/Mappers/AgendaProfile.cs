using AjudAkiWeb.Models;
using AutoMapper;
using Core.Models;

namespace AjudAkiWeb.Mappers
{
    public class AgendaProfile : Profile
    {
        public AgendaProfile()
        {
            CreateMap<AgendaViewModel, Agendum>().ReverseMap();
        }

    }
}
