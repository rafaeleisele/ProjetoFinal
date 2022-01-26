using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFinal.Models;

namespace ProjetoFinal.Services
{
    public class DepartmentService
    {
        private readonly ProjetoFinalContext _context;

        public DepartmentService(ProjetoFinalContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}