using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public GameObject 수1;
    public GameObject 수2;
    public GameObject 수3;
    public GameObject 수4;
    public GameObject 수5;
    public GameObject 수6;


    public GameObject 노아1;
    public GameObject 엘라1;
    GameObject 이전대상 = null;

    bool isFirstShowILL = true;


    bool 첫노아1 = false;


    public void 수호자1()
    {
        일러스트송출(수1);
    }
    public void 수호자2()
    {
        일러스트송출(수2);
    }
    public void 수호자3()
    {
        일러스트송출(수3);
    }
    public void 수호자4()
    {
        일러스트송출(수4);
    }
    public void 수호자5()
    {
        일러스트송출(수5);
    }
    public void 수호자6()
    {
        일러스트송출(수6);
    }







    public void 노아일러스트1()
    {

        일러스트송출(노아1);
    }
    public void 엘라일러스트1()
    {
        일러스트송출(엘라1);
    }


    public void allReset()
    {

    }

    void 일러스트송출(GameObject 대상)
    {



        if (isFirstShowILL)
        {
            대상.SetActive(true);
             이전대상 = 대상;
            isFirstShowILL = false;
        }

        else
        {

            이전대상.SetActive(false);
            대상.SetActive(true);
            이전대상 = 대상;
        }
    }



}
