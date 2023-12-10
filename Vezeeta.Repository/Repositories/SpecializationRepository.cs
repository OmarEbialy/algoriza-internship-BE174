using Vezeeta.Core.DTOs;
using Vezeeta.Core.Interfaces;
using Vezeeta.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Repository.Repositories
{
    internal class SpecializationRepository : ISpecializationService
    {
        private readonly VezeetaDbContext _dbContext;
        public SpecializationRepository(VezeetaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<SpecializationModel>> GetAllSpecializations()
        {
           
            try
            {
                //get all specializations
                var specializations = await _dbContext.Specializations
                    .Select(s => new SpecializationModel
                    {
                        Id = s.Id,
                        Name = s.Name
                    })
                    .ToListAsync();

                return specializations;
            }
            catch (Exception ex)
            {
                // handle exceptions as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
