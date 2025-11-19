namespace Core.Dto
{
    public class ServicoDTO
    {
        public uint IdServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorSugerido { get; set; }
        public uint IdProfissional { get; set; }
        public string FotoUrl { get; set; }
        public ProfissionalDTO Profissional { get; set; }

        public uint IdTipoServico { get; set; }
        public TipoServicoDTO TipoServico { get; set; }

        public uint IdAreaAtuacao { get; set; }
        public AreaAtuacaoDTO AreaAtuacao { get; set; }
    }
}
