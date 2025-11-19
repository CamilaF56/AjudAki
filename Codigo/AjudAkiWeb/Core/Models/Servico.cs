using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class Servico
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public DateTime Data { get; set; }

    public int IdTipoServico { get; set; }

    public int IdAreaAtuacao { get; set; }

    public int IdProfissional { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal ValorSugerido { get; set; }

    public string FotoUrl { get; set; } = null!;

    public virtual ICollection<Contratacao> Contratacaos { get; set; } = new List<Contratacao>();

    public virtual Areaatuacao IdAreaAtuacaoNavigation { get; set; } = null!;

    public virtual Pessoa IdProfissionalNavigation { get; set; } = null!;

    public virtual Tiposervico IdTipoServicoNavigation { get; set; } = null!;
}
