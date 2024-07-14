namespace StaticVariableClassesMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager.AddCourse("C#");
            CourseManager.AddCourse("Python");
            CourseManager.AddCourse("Java");
            CourseManager.GetCourses();
            CourseManager.IsCourseAvailable("Ruby");
            CourseManager.IsCourseAvailable("Java");
        }
    }

    static class CourseManager
    {
        static List<string> Courses = new List<string>();


        public static void AddCourse(string course)
        {
            Courses.Add(course);
            Console.WriteLine($"{course} added to the Course List.");

        }

        public static void GetCourses()
        {
            Console.WriteLine("All the available courses -");
            foreach (string course in Courses)
            {
                Console.WriteLine(course);
            }
        }

        public static void IsCourseAvailable(string course)
        {
            if(Courses.Contains(course))
                Console.WriteLine($"{course} is available.");
            else
                Console.WriteLine($"{course} is not available.");
        }
    }
}
