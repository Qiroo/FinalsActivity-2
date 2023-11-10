using System;
using FinalsActivity_2.Data;
using FinalsActivity_2.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalsActivity_2.Services
{
    public class BrandDataService : IBrandDataService
    {
        private AppDbContext _appDbContext;

        public BrandDataService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Brand>> GetBrandsAsync()
        {
            var brands = await _appDbContext.Brands.ToListAsync();
            return brands;
        }

        public List<Brand> GetBrands()
        {
            throw new NotImplementedException();
        }
    }
}

