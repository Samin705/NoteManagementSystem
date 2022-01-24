using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
    }
}
