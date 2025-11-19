using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class Areaatuacao
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Servico> Servicos { get; set; } = new List<Servico>();

    public virtual ICollection<Tiposervico> Tiposervicos { get; set; } = new List<Tiposervico>();
}
