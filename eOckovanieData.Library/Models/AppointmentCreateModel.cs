using System;

namespace eOckovanieData.Library.Models
{
    public class AppointmentCreateModel : IAppointmentModel
    {
        public int DocId { get; set; }
        public string UserId { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public TimeSpan Time1 { get; set; }
        public TimeSpan Time2 { get; set; }
        public int VacId { get; set; }
        public DateTime Date { get; set; }
    }
}
