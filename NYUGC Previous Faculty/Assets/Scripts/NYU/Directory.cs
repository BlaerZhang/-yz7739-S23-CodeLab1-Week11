using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Directory : MonoBehaviour
{
    public Text text; //variable for component that displays the text

    //NOTE: notice that this is a list of NYUPerson, but can still hold all subclasses. THAT'S POLYMORPHISM, BABY!
    public List<NYUPerson> nyuPeopleList; //list of people at nyu

    int recordNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        nyuPeopleList = new List<NYUPerson>();

        //make a new NYUFaculty 
        NYUPerson mattParker = new NYUFaculty("Matt Parker", "mp612", 1000000f, 9);

        NYUPerson eric = new NYUFaculty("Eric Zimmerman", "ez111", 10000000, 8);

        NYUPerson blaer = new NYUStudent("Blaer", "yz7739", 4.0f, 18);

        NYUPerson jesper = new NYUGCLeftFaculty("Jesper Juul", "jj1970", 1000000f, 3, 2010.13f);

        NYUPerson bennett = new NYUGCLeftFaculty("Bennett Foddy", "bf1978", 1000000, 8, 2021);

        NYUPerson frank = new NYUGCLeftFaculty("Frank Lantz", "fl1963", 1000000, 14, 2021);

        NYUPerson robert = new NYUGCLeftFaculty("Robert Yang", "ry2013", 1000000, 8, 2021);

        nyuPeopleList.Add(mattParker); //add mattParker to the nyuPeopleList
        
        nyuPeopleList.Add(jesper);
        
        nyuPeopleList.Add(bennett);
        
        nyuPeopleList.Add(frank);
        
        nyuPeopleList.Add(robert);
        
        UpdateRecord(); //update the text display to show the the info from the first person in the list
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){ //if space is pressed
            UpdateRecord(); //change the record to display the next person in the list
        }
    }

    void UpdateRecord(){
        NYUPerson person = nyuPeopleList[recordNum % nyuPeopleList.Count]; //grab the object a person in the list (use % to wrap around)

        text.text = person.ShowRecord(); //display the info for this object

        recordNum++; //increase the recordNum so we show the next person next time through
    }
}
