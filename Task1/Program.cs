using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        var classes = new[]
        {
           new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
           new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
           new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
       };
        var allStudents = GetAllStudents(classes);

        Console.WriteLine(string.Join(" ", allStudents));
    }

    /// <summary>
    /// - Метод SelectMany собирает все элементы вложенной коллекции (Students) в одну последовательность и возвращаем массив
    /// </summary>
    /// <param name="classes"></param>
    /// <returns></returns>
    static string[] GetAllStudents(Classroom[] classes)
    {
        return classes.SelectMany(classroom => classroom.Students).ToArray(); 
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}