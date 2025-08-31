namespace StudentManagement.Models
{
    public class Student
    {
        private static int _counter = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Id = _counter++;
            Name = name;
            Age = age;
        }
    }
}
