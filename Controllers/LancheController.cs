using LanchesMa.Models;
using LanchesMa.Repositories.Interfaces;
using LanchesMa.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMa.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches; // Trazer um lista do lanche
            string categoriaAtual = string.Empty;  // categoria vazia para amarzenar informação

            if (string.IsNullOrEmpty(categoria)) // condição na qual vai retorna todos os lanches por ordem de criação
            {
                lanches = _lancheRepository.Lanche.OrderBy(l => l.LancheId);
            }
            else// condição na qual vai trazer os lanche de acordo com a categoria que o usuario selelecionou
            {
                lanches = _lancheRepository.Lanche.Where(l => l.Categoria.CategoriaNome.Equals(categoria)).OrderBy(c => c.LancheName);
                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };



            return View(lanchesListViewModel);
        }
    }
}
