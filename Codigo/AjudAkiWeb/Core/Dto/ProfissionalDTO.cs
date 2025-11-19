using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto
{
    public class ProfissionalDTO
    {
        public uint IdProfissional { get; set; }
        public uint IdPessoa { get; set; }
        public PessoaDTO Pessoa { get; set; }
    }

}
