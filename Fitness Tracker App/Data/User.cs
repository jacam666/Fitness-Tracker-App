using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker_App.Data
{
    public class User
    {
        public String FirstName;
        public String LastName;
        public DateTime DOB;
        public List<TrainingDay> TrainingDays;
    }
}
