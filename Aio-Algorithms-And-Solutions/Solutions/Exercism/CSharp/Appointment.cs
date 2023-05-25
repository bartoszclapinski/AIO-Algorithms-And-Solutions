namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime scheduledTime = DateTime.Parse(appointmentDateDescription);
        
        return scheduledTime;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.TimeOfDay >= new TimeSpan(12, 0, 0) && 
               appointmentDate.TimeOfDay < new TimeSpan(18, 0, 0);
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }    
}