using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUGCLeftFaculty : NYUFaculty
{
    public float yearLeft;

    public NYUGCLeftFaculty(string name, string netId, float salary, int yearsTaught, float yearLeft) :
        base(name, netId, salary, yearsTaught)

    {
        this.yearLeft = yearLeft;
        type = "NYU Game Center Former Faculty";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "Year Left: " + yearLeft + "\n";
    }
}
