using NoteManagementSystem.DTO;
using NoteManagementSystem.IRepo;
using NoteManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.Repo
{
    public class NoteInformation : INoteInformation
    {

        IList<Note> notes = new List<Note>();
        public CreateNoteDTO CreateNote(CreateNoteDTO obj)
        {
            try
            {
                var data = new Note
                {
                    NoteId = new Guid(),
                    NoteName = obj.NoteName,
                    MyNote = obj.MyNote,
                    NoteTypeId = obj.NoteTypeId,
                    IsTaskComplete = obj.IsTaskComplete,
                    BookMarkUrl = obj.BookMarkUrl,
                    Reminder = obj.Reminder,
                    NoteTypeName = obj.NoteTypeName,
                    UserId = obj.UserId
                };
                notes.Add(data);
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetNotesForDashBoard(long UserId)
        {
            var data = (from n in notes
                        where n.UserId == UserId
                        select new
                        {
                            NoteName = n.NoteName,
                            NoteTypeName = n.NoteTypeName,
                            MyNote = n.MyNote,
                            NoteTypeId = n.NoteTypeId,
                            IsTaskComplete = n.IsTaskComplete,
                            BookMarkUrl = n.BookMarkUrl,
                            Reminder = n.Reminder,
                            UserId = n.UserId
                        }).ToList();
            return data;
        }
    }
}
