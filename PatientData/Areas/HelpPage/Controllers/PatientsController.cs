using MongoDB.Driver;
using MongoDB.Bson;
using PatientData.Areas.HelpPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatientData.Controllers
{
    public class PatientsController : ApiController
    {
        MongoCollection<Patient> _patients;
        public PatientsController()
        {
            _patients = PatientDb.Open();
        }
        public IEnumerable<Patient> Get()
        {
            return _patients.FindAll();
        }

        public IHttpActionResult Get(string id)
        {
            var patient = _patients.FindOneById(ObjectId.Parse(id));
            if(patient==null)
            {
                return NotFound();
                //return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient not found");

            }
            return Ok(patient);
            //return Request.CreateResponse(patient);
        }

        [Route("api/patients/{id}/medications")]
        public IHttpActionResult GetMedications(string id)
        {
            var patient = _patients.FindOneById(ObjectId.Parse(id));
            if (patient == null)
            {
                return NotFound();
                //return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient not found");

            }
            return Ok(patient.Medications);
            //return Request.CreateResponse(patient.Medications);
        }
    }
}
