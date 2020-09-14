using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientData.Areas.HelpPage.Models
{
    public static class PatientDb
    {
        public static MongoCollection<PatientData> Open()
            {
            var client = new MongoClient("mongdb://localhost");
            var server = client.GetServer();
            var db = server.GetDatabase("PatientDb");
            return db.GetCollection<PatientData>("Patients");
            }

    }
}