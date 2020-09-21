﻿using QuizAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizAPI.Controllers
{
    public class ParticipantController : ApiController
    {
        [HttpPost]
        [Route("api/InsertParticipant")]
        public Participant Insert(Participant model)
        {
            using(QuizDBEntities db =new QuizDBEntities())
            {
                db.Participants.Add(model);
                db.SaveChanges();
                return model;
            }
        }
        [HttpPost]
        [Route("api/UpdateOutput")]
        public void UpdateOutput(Participant model)
        {
            using(QuizDBEntities db=new QuizDBEntities())
            {
                db.Entry(model).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
