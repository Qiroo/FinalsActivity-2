using System;
using FinalsActivity_2.Models;

namespace FinalsActivity_2.Services
{
    public interface IBrandDataService
    {
        Task<List<Brand>> GetBrandsAsync();
    }
}