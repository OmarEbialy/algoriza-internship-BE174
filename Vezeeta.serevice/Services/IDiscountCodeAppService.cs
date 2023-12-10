using Vezeeta.serevice.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.serevice.Services
{
    public interface IDiscountCodeAppService
    {
        Task<bool> AddDiscountCode(DiscountCodeDTO discountCodeModel);
        Task<bool> UpdateDiscountCode(DiscountCodeUpdateDTO discountCodeUpdateModel);
        Task<bool> DeleteDiscountCode(int id);
        Task<bool> DeactivateDiscountCode(int id);
    }
}
