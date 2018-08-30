﻿using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string departement;
    private string email;
    private int age;

    public Employee(string name, decimal salary, string position, string departement)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.departement = departement;
        this.age = -1;
        this.email = "n/a";
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            this.email = value;
        }
    }

    public int Age { get { return this.age; } set { this.age = value; } }

    public string Department { get { return this.departement; } }

    public decimal Salary { get { return this.salary; } }

    public string PrintEmployeeInfo()
    {
        return $"{this.name} {this.Salary:f2} {this.Email} {this.Age}";
    }



}

