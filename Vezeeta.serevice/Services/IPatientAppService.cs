using Vezeeta.serevice.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vezeeta.serevice.Services
{
    public interface IPatientAppService
    {
        Task<bool> Register(PatientRegistrationDTO patientModel);
        Task<bool> Login(string email, string password);
        Task<List<DoctorDTO>> GetAllDoctors(int page, int pageSize, string search);
        Task<bool> BookAppointment(AppointmentBookingDTO appointmentBookingModel);
        Task<List<AppointmentDTO>> GetAllBookings(int patientId);
        Task<bool> CancelBooking(int bookingId, int patientId);
    }
}
