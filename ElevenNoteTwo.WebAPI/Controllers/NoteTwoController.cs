﻿using ElevenNoteTwo.Models;
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

        public IHttpActionResult Get(int id)
        {
            NoteTwoService noteService = CreateNoteTwoService();
            var note = noteService.GetNoteById(id);
            return Ok(note);
        }

        public IHttpActionResult Put(NoteTwoEdit note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateNoteTwoService();

            if (!service.UpdateNote(note))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateNoteTwoService();

            if (!service.DeleteNote(id))
                return InternalServerError();

            return Ok();
        }
    }
}
