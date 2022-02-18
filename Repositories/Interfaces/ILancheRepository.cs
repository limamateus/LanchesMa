using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesMa.Models;

namespace LanchesMa.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        public IEnumerable<Lanche> Lanche { get; }

        public IEnumerable<Lanche> LanchePreferido { get; }

        public Lanche GetLancheBtId(int lancheId);
        
    }
}
