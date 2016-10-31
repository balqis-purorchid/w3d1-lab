![Makers Institute](https://makersinstitute.id/img/logo-makersinstitute.png)

# Lab Week 3 Day 1

## Objective

This repo contain C# project. Your task is to complete the code so that no errors at all.

### Step 1: Download this repo
You can download this repo, or fork and then clone to your local, or even clone straight from your visual studio. You can see [here](https://www.visualstudio.com/en-us/docs/git/gitquickstart) if you want to clone straight from your visual studio.

### Step 2: 
First, you are given `Rectangle` class. You are going to create `Square` class that inherit from `Rectangle` class. Your task is to create 2 constructor in this class, zero parameter constructor and one parameter constructor. Here is the `Rectangle` class.

```
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
```

Inside zero parameter constructor, initialize inherited fields from `Rectangle`, which is `width` and `height`, and set it to `1`. On the other hand, inside one parameter constructor, initialize inherited fields `width` and `height`, with the same number as the parameter that passed by to this constructor. **Hint:** `width` and `height` is `private` so you have to use properties instead.

You can always check your code to see if it works or not by clicking Test > Run > All Tests. Be careful, typos can make an error, so keep an eye to the all small things.

### Step 3:
This time you're given `Person` class. You're task is to create `Teacher` class and `Student` class inherited from `Person` class. Here is the `Person` class.

```
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
```

For `Teacher` class, you have to add *private* field `subject` type **string**, and add `Teaching()` method that return string like this **"`name` is teaching `subject` right now."**. `name` and `subject` are fields from this class. 

And for `Student` class, you have to add *private* field `subject` and *private* field `score`. `subject` is type **string** and `score` is type **integer**.  

## Contributions
If you see a problem or a typo, please fork, make the necessary changes, and create a pull request so we can review your changes and merge them into the master repo and branch.
