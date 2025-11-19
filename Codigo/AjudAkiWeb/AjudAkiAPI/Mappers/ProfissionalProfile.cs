using AjudAkiWeb.Models;
using AutoMapper;
using Core.Models;

namespace AjudAkiWeb.Mappers
{
    public class ProfissionalProfile : Profile
    {
        public ProfissionalProfile()
        {
            CreateMap<ProfissionalViewModel, Pessoa>().ReverseMap();
        }
    }
}
