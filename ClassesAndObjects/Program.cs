namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student _student = new Student();
            _student.DisplayDetails();
            Console.ReadKey();
        }
    }

    class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Grade { get; set; }
        public Student()
        {
            Name = "Anonyn";
            Age = 20;
            Grade = "A";
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name};Age: {Age};Grade:{Grade}");
        }



    }
}
