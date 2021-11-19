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

        private Dictionary<string, string> _chestExercisePicturePaths = new()
        {
            ["Incline Barbell Press"] = "/ExerciseImages/Chest - incline barbell press Screenshot 2021-11-10 173214.png",
            ["cable crossover"] = "/ExerciseImages/Chest - cable crossover Screenshot 2021-11-10 173300.png",
            ["decline dumbbell flyes"] = "/ExerciseImages/Chest - decline dumbbell flyes Screenshot 2021-11-10 172917.png",
            ["Dips"] = "/ExerciseImages/Chest - Dips Screenshot 2021-11-10 180040.png",
            ["Dumbbell pullover"] = "/ExerciseImages/Chest - Dumbbell pullover Screenshot 2021-11-10 175952.png",
            ["flat dumbbell flyes"] = "/ExerciseImages/flat-dumbbell-flyes.png",
            ["incline dumbbell press"] = "/ExerciseImages/incline-dumbbell-press.png",
            ["incline dumbbell flyes"] = "/ExerciseImages/Chest - incline dumbell flyes Screenshot 2021-11-10 173123.png",
            ["Pec Dec"] = "/ExerciseImages/Chest - Pec Dec Screenshot 2021-11-10 173441.png",
            ["Pushups"] = "/ExerciseImages/Chest - Pushups Screenshot 2021-11-10 175828.png",
            ["Decline Barbell press"] = "/ExerciseImages/Chest-Decline Barbell press.png",
            ["incline dumbbell press"] = "/ExerciseImages/Chest - incline dumbbell press chest Screenshot.png",

        };

        public Dictionary<string,string> ChestExercisePicturePaths
        {
            get { return _chestExercisePicturePaths; }
        }

        private Dictionary<string, string> _backExercisePicturePaths = new()
        {
            ["Barbell Row"] = "/ExerciseImages/Back exercise deadlift Screenshot 2021-11-10 154854.png",
            ["Single Arm Dumbbell Row"] = "/ExerciseImages/Back - Dumbbell bench Row Screenshot 2021-11-10 155659.png",
            ["LatPulldown machine"] = "/ExerciseImages/Back - Lat Pulldown Screenshot 2021-11-10 155518.png",
            ["Bodyweight Pullups"] = "/ExerciseImages/Back - Pullups Screenshot 2021-11-10 155831.png",
            ["Seated Cable Row"] = "/ExerciseImages/Back - Seated Cable Row Screenshot 2021-11-10 155742.png",
            ["T-Bar Row"] = "/ExerciseImages/Back - T-Bar Row Screenshot 2021-11-10 155900.png",
        };


        public Dictionary<string,string> BackExercisePicturePaths
        {
            get { return _backExercisePicturePaths; }
        }

        private readonly Dictionary<string, string> _LegExercisePicturePaths = new()
        {
            ["Dumbbell Squats"] = "/ExerciseImages/LEGS - Dumbbell Squats.png",
            ["Barbell Lunges"] = "/ExerciseImages/LEGS- Barbell Lunges.png",
            ["Barbell Squat"] = "/ExerciseImages/LEGS- Barbell Squat.png",
            ["Dumbbell Lunges"] = "/ExerciseImages/LEGS- Dumbbell Lunges.png",
            ["Dumbbell Split Squat"] = "/ExerciseImages/LEGS- Dumbbell Split Squat.png",
            ["Leg Extention"] = "/ExerciseImages/LEGS- Leg Extention.png",
            ["Leg Press"] = "/ExerciseImages/LEGS- Leg Press.png",
            ["Lying Leg Curl"] = "/ExerciseImages/LEGS- Lying Leg Curl.png",
            ["Seated Leg Curl"] = "/ExerciseImages/LEGS- Seated Leg Curl.png",
        };

        public Dictionary<string, string> LegExercisePicturePaths
        {
            get { return _LegExercisePicturePaths; }
        }

        private readonly Dictionary<string, string> _ShoulderExercisePicturePaths = new()
        {
           
        };

        public Dictionary<string, string> ShoulderExercisePicturePaths
        {
            get { return _ShoulderExercisePicturePaths; }
        }


        public void AddUser(User u)
        {
            CurrentUser = u;           
        }
    

        public void AddNewWorkout(Workout aWorkout)
        {
            CurrentUser.TrainingDays.Last().Workouts.Add(aWorkout);
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
        ////public User LoadUserDetails { get; set; }           
        public void ReadXML()
        {
            XmlSerializer reader = new XmlSerializer(typeof(User));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            FileStream file = File.OpenRead(path);

            CurrentUser = reader.Deserialize(file) as User;
           
            file.Close();
        }
    }

     
    //TODO: keep me in the loop so i dont get pissy <= !

    //TODO: Create a LoadXML method that loads this data back into CurrentUser variable.
    //TODO: Check if it works! (maybe put a testload button in some component

    //TODO: with the constructor video, make the dataservice load this data automatically at startup





}

