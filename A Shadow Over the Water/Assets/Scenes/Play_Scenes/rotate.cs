using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float timer;
    int waitingTime;
    int updownder;
    int 넘 =  0;
    public Animator UD;
    public Animator Ten;
    public GameObject ring1;
    public GameObject ring2;
    public GameObject ring3;
    public GameObject ring4;
    bool 촉수체커 = false;
    public bool isRing1End= false;
    public bool isRing2End = false;
    public bool isRing3End = false;
    public bool isRing4End = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 5;
        넘 = 0;
        촉수체커 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {if(collision.tag == "ring1")
        {
            isRing1End = true;
        }

        if (collision.tag == "ring2")
        {
            isRing2End = true;
        }
        if (collision.tag == "ring3" )
        {

            updownder = 2;
            isRing3End = true;

            if(촉수체커 == true)
            {
                넘 = 3;
                Ten.SetInteger("Ten", 넘);
            }
        }
        if (collision.tag == "ring4")
        {
            isRing4End = true;
        }

    }


    public float turnSpeed1 = 30;
    public float turnSpeed2 = 40;
    public float turnSpeed3 = 20;
    public float turnSpeed4 = 30;

    bool isover = false;
    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > waitingTime && isover == false)
        {
            isover = true;
            updownder = 1;
            isRing1End = false;
            isRing2End = false;
            isRing3End = false;
            isRing4End = false;
            촉수체커 = true;


        }


        if (updownder == 0)
        {
            UD.SetInteger("upDowner", 0);
        }

        else if (updownder == 1)
        {
            UD.SetInteger("upDowner", 1);
        }

        else if (updownder == 2)
        {
            UD.SetInteger("upDowner", 2);
        }

        if(isRing1End == false)
        {
            ring1.transform.Rotate(Vector3.forward, turnSpeed1 * Time.deltaTime);
        }
        if (isRing2End == false)
        {
            ring2.transform.Rotate(Vector3.forward, turnSpeed2 * Time.deltaTime);
        }
        if (isRing3End == false)
        {
            ring3.transform.Rotate(Vector3.forward, turnSpeed3 * Time.deltaTime);
        }
        if (isRing4End == false)
        {
            ring4.transform.Rotate(Vector3.forward, turnSpeed4 * Time.deltaTime);
        }
    }
}
