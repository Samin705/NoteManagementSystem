using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.Models
{
    public class Note
    {
        public Guid NoteId { get; set; }
        public long UserId { get; set; }
        public long NoteTypeId { get; set; }
       
        public string NoteName { get; set; }
        public string NoteTypeName { get; set; }

        [StringLength(100, MinimumLength = 30, ErrorMessage = "Maximum 100 characters")]
        public string MyNote { get; set; }
        public DateTime? Reminder { get; set; }
        public bool? IsTaskComplete { get; set; }
        public string? BookMarkUrl { get; set; }
    }
}
