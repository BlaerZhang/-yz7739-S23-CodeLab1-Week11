using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUFaculty : NYUStaff
{
    public int yearsTaught = 2 ;

    public NYUFaculty(string name, string netId, float salary, int yearsTaught) : base(name, netId, salary)
    {
        this.name = name;
        this.netId = netId;
        this.salary = salary;
        this.yearsTaught = yearsTaught;

        type = "NYU Faculty";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "Years Taught: " + yearsTaught + "\n";
    }
}
