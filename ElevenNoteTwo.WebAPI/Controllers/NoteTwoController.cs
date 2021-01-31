using ElevenNoteTwo.Models;
using ElevenNoteTwo.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNoteTwo.WebAPI.Controllers
{
    [Authorize]
    public class NoteTwoController : ApiController
    {
        private NoteTwoService CreateNoteTwoService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new NoteTwoService(userId);
            return noteService;
        }

        public IHttpActionResult Get()
        {
            NoteTwoService noteService = CreateNoteTwoService();
            var notes = noteService.GetNotes();
            return Ok(notes);
        }

        public IHttpActionResult Post(NoteTwoCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateNoteTwoService();

            if (!service.CreateNoteTwo(note))
                return InternalServerError();

            return Ok();
        }
    }
}
