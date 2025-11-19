using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Service
{
    public interface IAvaliarService
    {
        uint Create(Avaliacao avaliar);
       
        Avaliacao? Get(uint id);

        IEnumerable<Avaliacao> GetAll();
    }
}
