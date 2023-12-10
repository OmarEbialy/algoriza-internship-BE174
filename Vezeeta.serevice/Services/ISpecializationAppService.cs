using Vezeeta.serevice.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vezeeta.serevice.Services
{
    public interface ISpecializationAppService
    {
        Task<List<SpecializationDTO>> GetAllSpecializations();
    }
}
