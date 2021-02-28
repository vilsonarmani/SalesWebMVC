using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            //old construction
            return _context.Seller.ToList();
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            //return _context.Seller.Remove(obj => obj.Id == id)
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();

        }

        public async Task RemoveAsync(int id)
        {
            //return _context.Seller.Remove(obj => obj.Id == id)
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();

        }


        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public void Update(Seller seller)
        {
            //any retorna true se existe no banco de dados o que vc colocar entre parenteses
            if (!_context.Seller.Any(x => x.Id == seller.Id))
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public async Task UpdateAsync(Seller seller)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == seller.Id);

            //any retorna true se existe no banco de dados o que vc colocar entre parenteses
            if (! hasAny)
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(seller);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
