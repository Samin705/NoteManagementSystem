using NoteManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.IRepo
{
    public interface INoteInformation
    {
        public CreateNoteDTO CreateNote(CreateNoteDTO obj);
        public Task<object> GetNotesForDashBoard(long UserId);
    }
}
