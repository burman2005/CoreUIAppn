using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core3MeetingApplication.Models
{
    public class Meeting
    {
        [Key]
        public int MeetingId { get; set; }
        [Required]
        [Column(TypeName="varchar(100)")]
        public string MeetingSubject   { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Attendees { get; set; }
        [Required]
        [Column(TypeName = "varchar(4000)")]
        public string MeetingAgenda  { get; set; }
        [Required]
        public DateTime MeetingDate { get; set; }
    }
}
