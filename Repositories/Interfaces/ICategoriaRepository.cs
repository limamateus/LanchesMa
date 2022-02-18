using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesMa.Models;

namespace LanchesMa.Repositories.Interfaces
{
    interface ICategoriaRepository
    {
        public IEnumerable<Categoria> Categoria { get; }
    }
}
