using AjudAkiWeb.Models;
using AutoMapper;
using Core.Models;

namespace AjudAkiWeb.Mappers
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteViewModel, Pessoa>().ReverseMap();
        }
    }
}
