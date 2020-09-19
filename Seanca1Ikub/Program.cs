using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seanca1Ikub
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Seanca 1: Write a program to print the name, salary and date of joining of 10 employees in a company. Use array of objects.\n\n");
      Console.WriteLine("Seanca 1\n\n");
      Employee[] employees = new Employee[]
        { new Employee("Ana", 400, new DateTime(2020, 04, 14)),
          new Employee("Genti", 500, new DateTime(2020, 04, 14)),
          new Employee("Bryan", 450, new DateTime(2020, 03, 13)),
          new Employee("Sofia", 400, new DateTime(2020, 01, 14)),
          new Employee("Eleni", 600, new DateTime(2020, 02, 14)),
          new Employee("Besa", 400, new DateTime(2020, 04, 14)),
          new Employee("Bruna", 500, new DateTime(2020, 04, 14)),
          new Employee("Ortis", 600, new DateTime(2020, 04, 14)),
          new Employee("Dafina", 500, new DateTime(2020, 02, 14)),
          new Employee("Mira", 400, new DateTime(2020, 04, 14))};
      for (int i = 0; i < employees.Length; i++)
      { Console.WriteLine(i + 1 + ". Name:" + employees[i].Name + "\tSalary:" + employees[i].Salary + "\tDate of joining:" + employees[i].DateOfJoining.ToString() + "\n"); }


      //Console.WriteLine("Write a program that allows a teacher to enter in an amount \n of students. For each" +
      //         "student ask the teacher to enter in their name and final score for the class.\n When" +
      //         "the teacher is done entering the data, print the highest grade in the class,\n and the" +
      //      " average grade for the class.\n\n");

      Console.WriteLine("Seanca 2. Detyra 1:\n\n");
      Console.WriteLine("Shkruani numrin e studenteve e studenteve:");
      var nr = Console.ReadLine();
      int studentNr;
      while (!int.TryParse(nr, out studentNr))
      {
        Console.WriteLine("Shkruani numrin e studenteve e studenteve:");
        nr = Console.ReadLine();
      }
      Student maxGrade = new Student();
      float max = 0;
      float sum = 0;
      for (int i = 1; i <= studentNr; i++)
      {
        Console.WriteLine("Shkruani emrin e studentit:");
        string name = Console.ReadLine();
        Console.WriteLine("Shkruani noten e studentit:");
        var Grade = Console.ReadLine();
        float grade;
        while (!float.TryParse(Grade, out grade))
        {
          Console.WriteLine("Shkruani noten e studentit:");
          Grade = Console.ReadLine();
        }
        sum += grade;
        if (grade > max)
        {
          max = grade;
          maxGrade.Name = name;
          maxGrade.Grade = grade;
        }
      }
      var average = sum / studentNr;
      Console.WriteLine("Strudenti me noten me te larte eshte " + maxGrade.Name + " me note " + maxGrade.Grade + "\n" +
        "Mesatarja e notave eshte: " + average);

      //Create a class named Taxpayer.Data fields for Taxpayer objects 
      // include the Social Security number, the yearly gross income, and the tax 
      //owed.Include a property with get and set accessors for the first two data fields,
      //   but make the tax owed a read-only property.
      //The tax should be calculated whenever the income is set.
      //Assume the tax is 15 % of income for incomes under $30,000 and 28 % for incomes that are $30,000 or higher.
      //Write a program that declares an array of ten Taxpayer objects.Prompt the user for data for each object and display the ten objects.

      Console.WriteLine("Seanca 2. Detyra 2:\n\n");
      Taxpayer[] taxpayers = new Taxpayer[3]; 
      for(int i=0; i < taxpayers.Length; i++)
      {
        Console.WriteLine(i + ".Shkruani Social Security Number:\n");
        var ssnr = Console.ReadLine();
        int Ssnr;
        while (!int.TryParse(ssnr, out Ssnr))
        {
          Console.WriteLine(i + ".Shkruani Social Security Number:\n");
          ssnr = Console.ReadLine();
        }
        Console.WriteLine(i + ".Shkruani te ardhurat tuaja:\n");
        var income = Console.ReadLine();
        float inc;
        while(!float.TryParse(income, out inc))
        {
          Console.WriteLine(i + ".Shkruani te ardhurat tuaja:\n");
          income = Console.ReadLine();
        }
        taxpayers[i] = new Taxpayer(Ssnr, inc);

      }
      for(int i=0;i<taxpayers.Length; i++)
      {
        Console.WriteLine(i + ".Ssnr:" + taxpayers[i].ssnr + "\tTe ardhurat:" + taxpayers[i].Income + "\tTaksa:" + taxpayers[i].taxOwed + "\n");
      }
    }

    
  }
  
}
