using System;

namespace eOckovanieData.Library.Models
{
    public interface IAppointmentModel
    {
        int DoctrorId { get; set; }
        string Location { get; set; }
        string Status { get; set; }
        DateTime Time1 { get; set; }
        DateTime Time2 { get; set; }
        int VaccineId { get; set; }
        DateTime Date { get; set; }
    }
}