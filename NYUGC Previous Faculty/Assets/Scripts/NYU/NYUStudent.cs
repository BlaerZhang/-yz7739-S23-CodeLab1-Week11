using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUStudent : NYUPerson
{
    public float gpa = 4.0f;

    public int credits = 0;

    public NYUStudent(string name, string netId, float gpa, int credits) : base(name, netId)
    {
        this.gpa = gpa;
        this.credits = credits;
        
        type = "NYU Student";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "GPA: " + gpa;
    }
}
