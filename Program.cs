using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Student Management System =====");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. View Student");
        Console.WriteLine("3. Exit");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.WriteLine("\nStudent Added Successfully!");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Student details will be displayed here.");
        }
        else if (choice == 3)
        {
            Console.WriteLine("Thank you!");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}