using Fitness_Tracker_App.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FitnessWebApp.Data
{
    public class DataService
    {
        private List<User> _users = new List<User>();
        [Obsolete("For now we just use the CurrentUser Property")]
        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        private List<String> _chestExerciseNames = new()
        {
            "Barbell Bench Press",
            "Incline Barbell Bench",
            "Cable Flyes",
            "Decline Barbell Bench",
            "Dumbbell Flyes",
            "Pec Dec",
            "Cable Crossover"
        };

        public List<String> ChestExerciseNames
        {
            get { return _chestExerciseNames; }
            set { _chestExerciseNames = value; }
        }

        private List<String> _LegExerciseNames = new()
        {
            "Barbell Squats",
            "Leg Press",
            "Leg extensions",
            "Hack Squats",
            "Walking Lunges",
            "Seated leg curl",
            "Lying Leg Curl"
        };

        public List<String> LegExerciseNames
        {
            get { return _LegExerciseNames; }
            set { _LegExerciseNames = value; }
        }

        private List<String> _BackExerciseNames = new()
        {
            "Barbell Row",
            "Cable Lat Pulldown",
            "Close grip Cable Pulldown",
            "Single Arm Dumbbell row",
            "Machine Back extension",
            "Seated Cable row",
            "Rack Pulls"
        };
        public List<String> BackExerciseNames
        {
            get { return _BackExerciseNames; }
            set { _BackExerciseNames = value; }
        }

        private List<String> _ShoulderExerciseNames = new()
        {
            "Barbell Press",
            "Dumbbell Press",
            "Dumbbell side raises",
            "Dumbbell Front raises",
            "Reverse Pec Dec",
            "Barbell Shrugs",
            "Cable Upright Rows"
        };

        public List<String> ShoulderExerciseNames
        {
            get { return _ShoulderExerciseNames; }
            set { _ShoulderExerciseNames = value; }
        }

        private List<String> _ArmExerciseNames = new()
        {
            "Barbell Curls",
            "Cable Rope curls",
            "Seated machine curls",
            "Dumbbell Concertration curls",
            "Close grip Bench press",
            "Rope cable Pushdown",
            "Dumbbell Tricep Extension",
            "Dumbbell Kickbacks",
            "Single arm cable pushdowns"
        };

        public List<String> ArmExerciseNames
        {
            get { return _ArmExerciseNames; }
            set { _ArmExerciseNames = value; }
        }

        public void AddUser(User u)
        {
            CurrentUser = u;
            //store (maybe xml, maybe database) => for now definitely XML! =)
        }

        public User CurrentUser { get; set; }


        public void WriteXML()
        {

            XmlSerializer writer = new XmlSerializer(typeof(User));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, CurrentUser);
            file.Close();
        }

        public User LoadUserDetails { get; set; }

        
            public String SavedUserDetails;
        public void ReadXML()
        {
            XmlSerializer reader = new XmlSerializer(typeof(User));

            System.IO.StreamReader file = new System.IO.StreamReader(@"//SerializationOverview.xml");

            User overview = (User)reader.Deserialize(file);
            file.Close();

            //Console.WriteLine(overview.SavedUserDetails);

        }
    }

 





    //TODO: keep me in the loop so i dont get pissy <= !

    //TODO: Create a LoadXML method that loads this data back into CurrentUser variable.
    //TODO: Check if it works! (maybe put a testload button in some component

    //TODO: with the constructor video, make the dataservice load this data automatically at startup





}

