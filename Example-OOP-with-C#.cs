//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

//For test this code use this online tool -->http://rextester.com/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester {

 public interface Actions {
  void SayHello();
 }

 public class Person: Actions {
  protected string name;
  private int Age; // Backing store
  private string Occupation; // Backing store
  public int age {
   get {
    return Age;
   }
   set {
    Age = value;
   }
  }
  public string occupation {
   get {
    return Occupation;
   }
   set {
    Occupation = value;
   }
  }

  public Person(string name, int age) {
   this.name = name;
   this.age = age;
   this.occupation = "don't declared";
  }

  public Person(string name, int age, string occupation) {
   this.name = name;
   this.age = age;
   this.occupation = occupation;
  }

  public void SayHello() {
   Console.WriteLine("Hello! " + "I'm " + name);
  }

  public void HappyBirthDay() {
   age++;
   Console.WriteLine("Happy Birthday! " + name);
  }

  public virtual void PrintDetails() {
   Console.WriteLine("Name: " + name);
   Console.WriteLine("Age: " + age);
   Console.WriteLine("Occupation: " + occupation);
   Console.WriteLine("===========================");
  }
 }

 public class Driver: Person {

  private int id;
  private string category;

  public Driver(string name, int age, string occupation, int id, string category): base(name, age, occupation) {
   this.id = id;
   this.category = category;
  }

  public override void PrintDetails() {
   Console.WriteLine("Name: " + name);
   Console.WriteLine("Age: " + age);
   Console.WriteLine("Occupation: " + occupation);
   Console.WriteLine("Category: " + category);
   Console.WriteLine("ID: " + id);
   Console.WriteLine("===========================");
  }
 }


 public class Program {
  public static void Main(string[] args) {
   Person John = new Person("John", 25);
   John.PrintDetails();

   Person Carol = new Person("Carol", 22, "Student");
   Carol.PrintDetails();
   //Carol say: I have a new job, I'm a Teacher
   Carol.occupation = "Teacher";
   Carol.PrintDetails();
   //Carol say: Today is my happy birthday!
   Carol.HappyBirthDay();
   Carol.PrintDetails();

   Driver Senna = new Driver("Senna", 33, "Driver F1", 192233, "F1");
   Senna.PrintDetails();

   Actions[] personActions = {
    Senna,
    Carol
   };

   foreach(Person person in personActions) {
    person.SayHello();
   }
  }
 }
}