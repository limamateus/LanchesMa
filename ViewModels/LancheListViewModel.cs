using LanchesMa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMa.ViewModels
{
    public class LancheListViewModel
    {

        public IEnumerable<Lanche> Lanches { get; set; }


        public string CategoriaAtual { get; set; }
    }
}
