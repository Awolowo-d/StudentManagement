using System;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());
                        studentService.AddStudent(new Student(name, age));
                        break;

                    case "2":
                        studentService.ViewStudents();
                        break;

                    case "3":
                        Console.Write("Enter Student ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter New Age: ");
                        int newAge = int.Parse(Console.ReadLine());
                        studentService.UpdateStudent(updateId, newName, newAge);
                        break;

                    case "4":
                        Console.Write("Enter Student ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        studentService.DeleteStudent(deleteId);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
