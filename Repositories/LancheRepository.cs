using LanchesMa.Context;
using LanchesMa.Models;
using LanchesMa.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMa.Repositories
{
    public class LancheRepository : ILancheRepository
    {

        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanche => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchePreferido => _context.Lanches.Where(l => l.LanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheBtId(int lancheId)
            {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }

    }
}
