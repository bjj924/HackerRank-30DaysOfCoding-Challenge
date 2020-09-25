using System;
using System.Collections.Generic;
using System.Text;

namespace _30DaysOfCoding.Days.Day_12
{
    public class Day12
    {
        public static void InharenceExercise()
        {
            Console.WriteLine("Ingrese nombre y apellido del alumno seguido del legajo: ");
            Console.WriteLine("(Ejemplo: Heraldo Memelli 8135627)");
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            Console.WriteLine("Ingrese la cantidad de notas: ");
            int numScores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las notas seguidas de un espacio: ");
            Console.WriteLine("(Ejemplo: 8 10 9 7 6)");
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        } 
    }
}
