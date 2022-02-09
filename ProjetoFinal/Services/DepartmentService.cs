using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFinal.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.Services
{
    public class DepartmentService
    {
        private readonly ProjetoFinalContext _context;

        public DepartmentService(ProjetoFinalContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}