using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seanca1Ikub
{
  class Employee
  {
    private string name;
    private float salary;
    private DateTime dateOfJoining;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public float Salary
    {
      get { return salary; }
      set { salary = value; }
    }

    public DateTime DateOfJoining
    {
      get { return dateOfJoining; }
      set { dateOfJoining = value; }
    }
    
    public Employee(string n, float s, DateTime d)
    {
      name = n;
      salary = s;
      dateOfJoining = d;
    }
  }
}
