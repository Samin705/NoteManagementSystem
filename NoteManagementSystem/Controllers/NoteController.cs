using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteManagementSystem.DTO;
using NoteManagementSystem.IRepo;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.Controllers
{
    [Route("domain/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private INoteInformation _note;

        public NoteController(INoteInformation note)
        {
            _note = note;
        }

        [HttpPost]
        [Route("CreateNote")]
        [SwaggerOperation(Description = "Example {  }")]
        public IActionResult CreateNote(CreateNoteDTO obj)
        {
            return Ok(_note.CreateNote(obj));
        }

        [HttpGet]
        [Route("GetNotesForDashBoard")]
        [SwaggerOperation(Description = "Example {  }")]
        public IActionResult GetNotesForDashBoard(long UserId)
        {
            return Ok(_note.GetNotesForDashBoard(UserId));
        }
    }
}
