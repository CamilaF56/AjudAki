using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Service
{
    public interface ITipoServicoService
    {
        uint Create(Tiposervico tipoServico);

        void Edit(Tiposervico tipoServico);

        void Delete(uint id);

        Tiposervico? Get(uint id);

        IEnumerable<Tiposervico> GetAll();
    }
}
