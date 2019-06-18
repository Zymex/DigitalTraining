using DigitalTraining._ApplicationModels;
using DigitalTraining._ApplicationModels.GeneralTraining;
using DigitalTraining.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalTraining.Extensions
{
    public static class TrainingExtensions
    {
        public static void CreateTrainingDocument(this ApplicationContext db, TrainingDocument document)
        {
            db.Add(document);
            db.SaveChanges();
        }
        public static void AssignUserToTraining(this ApplicationContext db, TrainingRoster roster)
        {
            db.Add(roster);
            db.SaveChanges();
        }
    }
}
