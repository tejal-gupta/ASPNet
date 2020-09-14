using MongoDB.Driver.Linq;
using PatientData.Areas.HelpPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver.Linq;

namespace PatientData.Areas.HelpPage.App_Start
{
    public class MongoConfig
    {
        public static void Seed()
        {
            var patients = PatientDb.Open();

            if(!patients.AsQueryable().Any(p => p.Name == "Scott"))
                    {
                        
                    }
        }
    }
}