using Vezeeta.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.serevice.DTOs
{
    public class DayTimeSlotDTO
    {
        public Days Day { get; set; }
        public List<TimeSlotDTO> TimeSlots { get; set; }
    }
}
