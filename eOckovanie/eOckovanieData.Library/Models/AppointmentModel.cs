﻿using System;

namespace eOckovanieData.Library.Models
{
    public class AppointmentModel : IAppointmentModel
    {
        public int Id { get; set; }
        public int DoctrorId { get; set; }
        public string UserId { get; set; }
        public DateTime Time1 { get; set; }
        public DateTime Time2 { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public int VaccineId { get; set; }
        public DateTime Date { get; set; }
        }
}
