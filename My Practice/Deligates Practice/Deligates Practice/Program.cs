using System;

namespace Deligates_Practice
{
    public class Exercises
    {
        public void Warmup()
        {
            Console.WriteLine("Doing warm up");
        }
        
        public void cheastPress()
        {
            Console.WriteLine("Doing cheast Press");
        }

        public void Squats()
        {
            Console.WriteLine("Doing squats");
        }

        public void Legpress()
        {
            Console.WriteLine("Doing Legpress");
        }

        public void pushups()
        {
            Console.WriteLine("Doing Pushups");
        }
    }

    public class AdvancedExercises
    {
        public void Crossfits()
        {
            Console.WriteLine("Doing all cross fit exercises");
        }
    }

    public class ExerciseEditorWithDelegate
    {
        public delegate void ExerciseSelectorHandler();

        public void SelectExercise ( ExerciseSelectorHandler selector)
        {
            selector(); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciseSelectorWithDelegates:");
            var exercise = new Exercises();
            var advanceEx = new AdvancedExercises();
            var exerciseselector = new ExerciseEditorWithDelegate();

            ExerciseEditorWithDelegate.ExerciseSelectorHandler Cheastexerciseselector;
            Cheastexerciseselector = exercise.Warmup;
            Cheastexerciseselector += exercise.cheastPress;
            Cheastexerciseselector += exercise.pushups;

            ExerciseEditorWithDelegate.ExerciseSelectorHandler legexerciseselector;
            legexerciseselector = exercise.Warmup;
            legexerciseselector += exercise.Legpress;
            legexerciseselector += exercise.Squats;
            legexerciseselector += Lunges;

            ExerciseEditorWithDelegate.ExerciseSelectorHandler Cardio;
            Cardio = advanceEx.Crossfits;

            Console.WriteLine("CheastExercises:");
            exerciseselector.SelectExercise(Cheastexerciseselector);

            Console.WriteLine("LegExercise:");
            exerciseselector.SelectExercise(legexerciseselector);

            Console.WriteLine("Cardio:");
            exerciseselector.SelectExercise(Cardio);

            static void Lunges()
            {
                Console.WriteLine("doing lunges");
            }
        }
    }
}
