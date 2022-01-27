﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFinal.Models;
using Microsoft.EntityFrameworkCore;

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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int Id)
        {
            var obj = _context.Seller.Find(Id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}