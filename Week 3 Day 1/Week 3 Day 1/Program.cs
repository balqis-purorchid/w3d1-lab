using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_1
{
    class Rectangle
    {
        // Fields
        private int width;
        private int height;

        // Properties
        public int Width
        {
            get { return width; }
            set { width = value; } 
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        // Constructors
        public Rectangle()
        {
            Width = 1;
            Height = 1;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Methods
        public int getArea()
        {
            return Width * Height;
        }

        public int getCirc()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return "Rectangle" + "\n" +
                "Width: " + Width + "\n" +
                "Height: " + Height + "\n" +
                "Area: " + getArea() + "\n" +
                "Circumference: " + getCirc();
        }        
    }

    // ============================================================
    // Create Square class inherit from Rectangle here
    // ============================================================

    // Code Here

    // ============================================================

    class Person
    {
        // Fields
        private string name;
        private int age;

        // Properties
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Methods
        public override string ToString()
        {
            return "Person" + "\n" +
                "Name: " + Name + "\n" +
                "Age: " + Age + "\n";
        }
    }

    // ============================================================
    // Create Teacher class inherit from person here
    // ============================================================

    // Code Here

    // ============================================================





    // ============================================================
    // Create Student class inherit from person here
    // ============================================================

    // Code Here

    // ============================================================

















    // ===============================================================
    // ================ DO NOT EDIT THIS CODE BELOW ==================
    // ===============================================================

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please go to Test > Run > All Test");

            Console.ReadKey();
        }

        public static Type MagicallyCheckClass(string className)
        {
            Type type = Type.GetType("Week_3_Day_1." + className);

            return type;
        }
    }
}
