using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 장소정보창 : MonoBehaviour
{
    public GameObject 탐정사무소;
    public GameObject 의뢰자의집;
    public GameObject 데일리뉴스신문사;
    public GameObject 병원;


    /*
    public GameObject 노아1;
    public GameObject 노아2;
    public GameObject 노아3;
    public GameObject 노아4;
    public GameObject 노아5;
    public GameObject 노아6;
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        //노아정보업데이트문();

        //임시로 확인용으로 넣어둔 파일, 추후 삭제

        if (Input.GetKeyDown(KeyCode.F1))
        {
            DataBaseManager.노아정보2 = true;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            DataBaseManager.노아정보3 = true;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            DataBaseManager.노아정보4 = true;
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            DataBaseManager.노아정보5 = true;
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            DataBaseManager.노아정보6 = true;
        }


    }
    /*
    void 노아정보업데이트문()
    {
        if (DataBaseManager.노아정보1 == true)
        {
            노아1.SetActive(true);
        }
        else
        {
            노아1.SetActive(false);

        }

        if (DataBaseManager.노아정보2 == true)
        {
            노아2.SetActive(true);
        }
        else
        {
            노아2.SetActive(false);

        }

        if (DataBaseManager.노아정보3 == true)
        {
            노아3.SetActive(true);
        }
        else
        {
            노아3.SetActive(false);

        }

        if (DataBaseManager.노아정보4 == true)
        {
            노아4.SetActive(true);
        }
        else
        {
            노아4.SetActive(false);

        }

        if (DataBaseManager.노아정보5 == true)
        {
            노아5.SetActive(true);
        }
        else
        {
            노아5.SetActive(false);

        }

        if (DataBaseManager.노아정보6 == true)
        {
            노아6.SetActive(true);
        }
        else
        {
            노아6.SetActive(false);

        }
    }
    */
    public void 탐정사무소정보표기()
    {
        탐정사무소.SetActive(true);
        데일리뉴스신문사.SetActive(false);
        의뢰자의집.SetActive(false);
        병원.SetActive(false);
    }

    public void 데일리뉴스신문사정보표기()
    {
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(true);
        의뢰자의집.SetActive(false);
        병원.SetActive(false);
    }
    public void 의뢰자의집정보표기()
    {
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(false);
        의뢰자의집.SetActive(true);
        병원.SetActive(false);
    }
    public void 병원정보표기()
    {
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(false);  
        의뢰자의집.SetActive(false);
        병원.SetActive(true);
    }
}
