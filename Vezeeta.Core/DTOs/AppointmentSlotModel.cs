﻿using Vezeeta.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Core.DTOs
{
    public class AppointmentSlotModel
    {
        public int Id { get; set; }
        public Days Day { get; set; }
        public List<DateTime> Times { get; set; }
    }
}
