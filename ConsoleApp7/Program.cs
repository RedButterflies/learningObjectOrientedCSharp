//object oriented programming in C#
using System;
using System.Globalization;

class Human
{
   private string name;
   private string eyeColour;
   private string skinColour;
   private string hairColour;
   private int age;
   private double height;
   private double weight;
   public void myName ()
        {
        Console.WriteLine("My name is "+ name);
    }
    public void Introduction()
    {
        Console.WriteLine("My name is "+ name +". I am "+age + " years old. I have "+ eyeColour +" eyes, "+skinColour +" skin and "+ hairColour +" hair. I am "+ height +"cm tall and I weigh "+ weight +" kilograms"  );
    }
    Human()
        {
        }
    Human (String name, string eyeColour, string skinColour,string hairColour,int age, double height, double weight)
    {
        this.name =name;
        this.eyeColour =eyeColour;
        this.skinColour =skinColour;
        this.hairColour =hairColour;
        this.age =age;
        this.weight =weight;
        this.height =height;
       
    }
    
    static void Main(string[] args)
    {
        Human John= new Human("John","brown","light brown","dark brown",20,174.5d,55.6d);
        Console.WriteLine("Name: "+John.name);
        Console.WriteLine("Eye colour:"+John.eyeColour);
        Console.WriteLine("Skin colour:"+John.skinColour);
        Console.WriteLine("Hair colour: "+John.hairColour);
        Console.WriteLine("Age: "+John.age);
        Console.WriteLine("Weight: "+ John.weight);
        Console.WriteLine("Height: "+John.height);
        John.Introduction();

        Console.WriteLine();
        Human X = new Human();
        Console.WriteLine("Create a human ");
        Console.WriteLine("Enter the name: ");
        string name=Console.ReadLine();
        X.name = name;
        Console.WriteLine("Enter the eye colour: ");
        string eye_colour = Console.ReadLine();
        X.eyeColour = eye_colour;
        Console.WriteLine("Enter the skin colour: ");
        string skin_colour= Console.ReadLine();
        X.skinColour = skin_colour;
        Console.WriteLine("Enter the hair colour: ");
        string hair_colour= Console.ReadLine();
        X.hairColour = hair_colour;
        Console.WriteLine("Enter the age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        X.age = age;
        Console.WriteLine("Enter the weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        X.weight= weight;
        Console.WriteLine("Enter the height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        X.height = height;

        Console.WriteLine();
        Console.WriteLine("Your created human: ");
        Console.WriteLine("Name: " + X.name);
        Console.WriteLine("Eye colour: " + X.eyeColour);
        Console.WriteLine("Skin colour: " + X.skinColour);
        Console.WriteLine("Hair colour: " + X.hairColour);
        Console.WriteLine("Age: " + X.age);
        Console.WriteLine("Weight: " + X.weight);
        X.myName();
        X.Introduction();

    }
}
