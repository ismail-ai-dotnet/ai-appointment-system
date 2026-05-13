using System.ComponentModel.DataAnnotations;

namespace AppointmentBookingWithChatbot.Models

{
    public class Appointment
    {
       
            public int Id { get; set; }

            [Required]
            public string PatientName { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public string Phone { get; set; }

            [Required]
            public string DoctorName { get; set; }

            [Required]
            public DateTime AppointmentDate { get; set; }

            public string Message { get; set; }
        
    }
}
