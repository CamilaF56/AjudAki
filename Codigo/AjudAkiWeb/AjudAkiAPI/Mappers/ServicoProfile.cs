using AutoMapper;
using Core.Models;
using Core.Dto;
using AjudAkiWeb.Models;

namespace AjudAkiAPI.Mappers
{
    public class ServicoProfile : Profile
    {
        public ServicoProfile()
        {
            // -----------------------------------------
            // 1️⃣ Servico (Entity) → ServicoDTO
            // -----------------------------------------
            CreateMap<Servico, ServicoDTO>()
                .ForMember(dest => dest.IdServico, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
                .ForMember(dest => dest.ValorSugerido, opt => opt.MapFrom(src => src.ValorSugerido))
                .ForMember(dest => dest.IdProfissional, opt => opt.MapFrom(src => src.IdProfissional))
                .ForMember(dest => dest.IdTipoServico, opt => opt.MapFrom(src => src.IdTipoServico))
                .ForMember(dest => dest.IdAreaAtuacao, opt => opt.MapFrom(src => src.IdAreaAtuacao))
                .ForMember(dest => dest.FotoUrl, opt => opt.MapFrom(src => src.FotoUrl))

                .ForMember(dest => dest.Profissional, opt => opt.MapFrom(src => new ProfissionalDTO
                {
                    IdProfissional = (uint)src.IdProfissional,
                    IdPessoa = (uint)src.IdProfissionalNavigation.Id,

                    Pessoa = new PessoaDTO
                    {
                        IdPessoa = (uint)src.IdProfissionalNavigation.Id,
                        Nome = src.IdProfissionalNavigation.Nome,
                        Cpf = src.IdProfissionalNavigation.Cpf,
                        Telefone = src.IdProfissionalNavigation.Telefone,
                        Cep = src.IdProfissionalNavigation.Cep
                    }
                }))

                .ForMember(dest => dest.AreaAtuacao, opt => opt.MapFrom(src => new AreaAtuacaoDTO
                {
                    IdAreaAtuacao = (uint)src.IdAreaAtuacaoNavigation.Id,
                    Nome = src.IdAreaAtuacaoNavigation.Nome
                }))

                .ForMember(dest => dest.TipoServico, opt => opt.MapFrom(src => new TipoServicoDTO
                {
                    IdTipoServico = (uint)src.IdTipoServicoNavigation.Id,
                    Nome = src.IdTipoServicoNavigation.Nome
                }));


            // -----------------------------------------
            // 2️⃣ ServicoDTO → ServicoViewModel
            // -----------------------------------------
            CreateMap<ServicoDTO, ServicoViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdServico))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))

                // PROFISSIONAL
                .ForMember(dest => dest.IdProfissional, opt => opt.MapFrom(src => src.IdProfissional))
                .ForMember(dest => dest.IdPessoa, opt => opt.MapFrom(src => src.Profissional.IdPessoa))
                .ForMember(dest => dest.NomeProfissional, opt => opt.MapFrom(src => src.Profissional.Pessoa.Nome))
                .ForMember(dest => dest.TelefoneProfissional, opt => opt.MapFrom(src => src.Profissional.Pessoa.Telefone))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(src => src.Profissional.Pessoa.Cep))

                // ÁREA
                .ForMember(dest => dest.IdAreaAtuacao, opt => opt.MapFrom(src => src.AreaAtuacao.IdAreaAtuacao))
                .ForMember(dest => dest.NomeAreaAtuacao, opt => opt.MapFrom(src => src.AreaAtuacao.Nome))

                // TIPO
                .ForMember(dest => dest.IdTipoServico, opt => opt.MapFrom(src => src.TipoServico.IdTipoServico))
                .ForMember(dest => dest.NomeTipoServico, opt => opt.MapFrom(src => src.TipoServico.Nome));
        }
    }
}
