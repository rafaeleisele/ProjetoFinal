﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFinal.Models;

namespace ProjetoFinal.Services
{
    public class SellerService
    {
        private readonly ProjetoFinalContext _context;

        public SellerService(ProjetoFinalContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}