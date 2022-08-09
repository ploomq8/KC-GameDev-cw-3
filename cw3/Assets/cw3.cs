using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    // hero 

    string heroname = "plom";
    int heropower = 10;

    // villain

    string villainname = "aaz";
    int villainpower = 10;

    float playerspeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower)
        {
            print(heroname + " is stronger");
        }
        else if (heropower == villainpower)
        {
            print(heroname + " equals " + villainname);
        }
        else
        {
            print(villainname + " is stronger");
        }
        setspeed(2.5f);
    }

    void setspeed(float speed)
    {
        playerspeed = speed;
        print(playerspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
