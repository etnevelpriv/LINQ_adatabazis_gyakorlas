using System;
using System.Globalization;

namespace LINQ_adatbazis_feladat;

public class Diak
{
    public int Id {get;private set;}
    public string Name {get;private set;}
    public int Age {get;private set;}
    public string ClassName {get;private set;}
    public float Average {get;private set;}

    public Diak (int id, string name, int age, string classname, float average)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.ClassName = classname;
        this.Average = average;
    }
}
