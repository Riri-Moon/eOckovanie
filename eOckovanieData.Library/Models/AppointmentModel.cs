using System;

namespace eOckovanieData.Library.Models
{
    public class AppointmentModel : IAppointmentModel
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public string UserId { get; set; }
        public TimeSpan Time1 { get; set; }
        public TimeSpan Time2 { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public int VacId { get; set; }
        public DateTime Date { get; set; }
        }
}
