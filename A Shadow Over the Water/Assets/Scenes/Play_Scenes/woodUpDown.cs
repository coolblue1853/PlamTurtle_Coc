using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodUpDown : MonoBehaviour
{
    public Animator UD;
    public Animator Ten;
    // Start is called before the first frame update
    void Start()
    {



        
    }
    int updownder;
    int num=0;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            num = num + 1;

            Ten.SetInteger("Ten", num);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(updownder == 0)
            {
                updownder = 1;
            }

            else if (updownder == 1)
            {
                updownder = 2;
            }
            else if (updownder == 2)
            {
                updownder = 0;
            }
        }

        if (updownder == 0)
        {
            UD.SetInteger("upDowner",0);
        }

        else if (updownder == 1)
        {
            UD.SetInteger("upDowner", 1);
        }

        else if (updownder == 2)
        {
            UD.SetInteger("upDowner", 2);
        }
    }
}
