using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFinal.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}