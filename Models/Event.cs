using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        [Required(ErrorMessage = "Event No is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Event Name is required.")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }
    }
}
