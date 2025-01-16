using EventEase.Models;

namespace EventEase.Services
{
    public class AttendanceService
    {
        private List<Attendance> attendances = new List<Attendance>();

        public void MarkAttendance(Attendance attendance)
        {
            // Store attendance data (in memory or database)
            attendances.Add(attendance);
        }

        public List<Attendance> GetAttendanceForEvent(int eventId)
        {
            return attendances.Where(a => a.EventId == eventId).ToList();
        }
    }
}
