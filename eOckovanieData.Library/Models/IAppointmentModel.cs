using System;

namespace eOckovanieData.Library.Models
{
    public interface IAppointmentModel
    {
        int DocId { get; set; }
        string Location { get; set; }
        string Status { get; set; }
        TimeSpan Time1 { get; set; }
        TimeSpan Time2 { get; set; }
        int VacId { get; set; }
        DateTime Date { get; set; }
    }
}