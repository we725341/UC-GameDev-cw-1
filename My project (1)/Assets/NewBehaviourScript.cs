using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroname = ("super man");
        float heroHeight = 170.3f;
        int heroage = 33;
        string heroSuperPower = ("lazer");
        bool is_hero = true;

        print("hello my name is" + heroname + "and my age is" + heroage + "and my height is" + heroHeight + "and my power is" + heroSuperPower );

        string criminalname = ("criminal");
        float criminalheight = 155.4f;
        int criminalage = 54;
        string criminalpower = ("lazer gun");
        bool is_criminal = true;

        print("hello my name is" + criminalname + "and my age is" + criminalage + "and my height is" + criminalheight + "and my power is" + criminalpower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
