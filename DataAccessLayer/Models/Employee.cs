using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime Birthdate { get; set; }

    public int Age 
    {
        get { return GetAge(Birthdate); }
        set { value = GetAge(Birthdate); }
    }

    public string Gender { get; set; }

    public string Status { get; set; }

    public string Job { get; set; }

    public string Department { get; set; }

    public string Skills { get; set; }

    public int English { get; set; }

    public int Arabic { get; set; }

    public string EmployeeType { get; set; }

    public int GetAge(DateTime date)
    {
        if (date.Year == DateTime.Now.Year) return -1;
        return DateTime.Now.Year - date.Year;
    }
}
