using Vezeeta.serevice.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vezeeta.serevice.Services
{
    public interface IFeedbackAppService
    {
        Task<List<FeedbackDTO>> GetFeedbacksByDoctorId(int doctorId);
        Task<bool> AddFeedback(FeedbackAddDTO feedbackModel);
    }
}
