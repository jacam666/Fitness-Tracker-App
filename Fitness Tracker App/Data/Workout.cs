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

        //copy constructor
        public Workout(Workout originalWo)
        {
            ExerciseName = originalWo.ExerciseName;
            AmountOfSets = originalWo.AmountOfSets;
            AmountOfReps = originalWo.AmountOfReps;
            Weight = originalWo.Weight;
        }

    }
}
