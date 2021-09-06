using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleWapenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        인벤토리업데이터();
    }



    public GameObject 소형권총;
    public GameObject 리볼버;
    public GameObject 샷건;
    public GameObject 소총;

    public GameObject 단검;
    public GameObject 몽둥이;
    public GameObject 도끼;

    public GameObject 화염병;
    public GameObject 돌;

    void 인벤토리업데이터()
    {
        if(DataBaseManager.리볼버구매여부 == true)
        {
            리볼버.SetActive(true);
        }
        else
        {
            리볼버.SetActive(false);

        }
        if (DataBaseManager.소형권총구매여부 == true)
        {
            소형권총.SetActive(true);
        }
        else
        {
            소형권총.SetActive(false);

        }
        if (DataBaseManager.샷건구매여부 == true)
        {
            샷건.SetActive(true);
        }
        else
        {
            샷건.SetActive(false);

        }
        if (DataBaseManager.소총구매여부 == true)
        {
            소총.SetActive(true);
        }
        else
        {
            소총.SetActive(false);

        }

        if (DataBaseManager.단검구매여부 == true)
        {
            단검.SetActive(true);
        }
        else
        {
            단검.SetActive(false);

        }
        if (DataBaseManager.몽둥이구매여부 == true)
        {
            몽둥이.SetActive(true);
        }
        else
        {
            몽둥이.SetActive(false);

        }
        if (DataBaseManager.도끼구매여부 == true)
        {
            도끼.SetActive(true);
        }
        else
        {
            도끼.SetActive(false);

        }

        if (DataBaseManager.화염병보유수 >=1)
        {
            화염병.SetActive(true);
        }
        else
        {
            화염병.SetActive(false);

        }
        if (DataBaseManager.던지기 >=1)
        {
            돌.SetActive(true);
        }
        else
        {
            돌.SetActive(false);

        }


    }

}
