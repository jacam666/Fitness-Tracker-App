namespace Fitness_Tracker_App.Data
{
    public class Workout
    {
        public string ExerciseName;
        public int AmountOfSets;
        public int AmountOfReps;
        public double Weight;

        public Workout()
        {

        }

        public Workout(Workout w)
        {
            ExerciseName = w.ExerciseName;
            AmountOfSets = w.AmountOfSets;
            AmountOfReps = w.AmountOfReps;
            Weight = w.Weight;
        }
       
    }
}
