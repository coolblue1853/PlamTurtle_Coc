using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 이동제한 : MonoBehaviour
{
    public GameObject 대화창;
    public Mins 주인공;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(대화창.activeSelf == true)
        {
            주인공.isDialogOnChangeT();

        }

        else if (대화창.activeSelf == false)
        {
            주인공.isDialogOnChangeF();
        }
    }
}
