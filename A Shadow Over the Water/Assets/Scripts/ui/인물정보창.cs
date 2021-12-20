using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 인물정보창 : MonoBehaviour
{
    public GameObject 노아;
    public GameObject 멜리사;
    public GameObject 엘라트리스;
    public GameObject 에이든트리스;



    public GameObject 노아1;
    public GameObject 노아2;
    public GameObject 노아3;
    public GameObject 노아4;
    public GameObject 노아5;
    public GameObject 노아6;

    public GameObject 멜리사1;
    public GameObject 엘라1;
    public GameObject 에이든1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {



    }

    void 인물정보업데이터()
    {
        노아정보업데이트문();
        멜리사정보업데이트문();
        에이든정보업데이트문();
        엘라정보업데이트문();
    }

    void 노아정보업데이트문()
    {
        if (DataBaseManager.노아정보1 == true)
        {
            노아1.transform.SetAsFirstSibling();
            노아1.SetActive(true);
        }
        else
        {
            노아1.SetActive(false);

        }

        if (DataBaseManager.노아정보2 == true)
        {
            노아2.transform.SetAsFirstSibling();
            노아2.SetActive(true);
        }
        else
        {
            노아2.SetActive(false);

        }

        if (DataBaseManager.노아정보3 == true)
        {
            노아3.transform.SetAsFirstSibling();
            노아3.SetActive(true);
        }
        else
        {
            노아3.SetActive(false);

        }

        if (DataBaseManager.노아정보4 == true)
        {
            노아4.transform.SetAsFirstSibling();
            노아4.SetActive(true);
        }
        else
        {
            노아4.SetActive(false);

        }

        if (DataBaseManager.노아정보5 == true)
        {
            노아5.transform.SetAsFirstSibling();
            노아5.SetActive(true);
        }
        else
        {
            노아5.SetActive(false);

        }

        if (DataBaseManager.노아정보6 == true)
        {
            노아6.transform.SetAsFirstSibling();
            노아6.SetActive(true);
        }
        else
        {
            노아6.SetActive(false);

        }
    }

    void 멜리사정보업데이트문()
    {
        if (DataBaseManager.멜리사정보1 == true)
        {
            멜리사1.SetActive(true);
        }
        else
        {
            멜리사1.SetActive(false);

        }
    }
    void 에이든정보업데이트문()
    {
        if (DataBaseManager.에이든정보1 == true)
        {
            에이든1.SetActive(true);
        }
        else
        {
            에이든1.SetActive(false);

        }
    }
    void 엘라정보업데이트문()
    {
        if (DataBaseManager.엘라정보1 == true)
        {
            엘라1.SetActive(true);
        }
        else
        {
            엘라1.SetActive(false);

        }
    }

   
    public void 인물정보초기화()
    {
        노아.SetActive(false);
        멜리사.SetActive(false);
        엘라트리스.SetActive(false);
        에이든트리스.SetActive(false);
    }



    public void 노아정보표기()
    {
        인물정보업데이터();



        DataBaseManager.노아알리미 = false;
        노아.SetActive(true);
        멜리사.SetActive(false);
        엘라트리스.SetActive(false);
        에이든트리스.SetActive(false);
    }

    public void 멜리사정보표기()
    {
        인물정보업데이터();
        DataBaseManager.멜리사알리미 = false;
        노아.SetActive(false);
        멜리사.SetActive(true);
        엘라트리스.SetActive(false);
        에이든트리스.SetActive(false);
    }
    public void 엘라트리스정보표기()
    {
        인물정보업데이터();
        DataBaseManager.엘라알리미 = false;
        노아.SetActive(false);
        멜리사.SetActive(false);
        엘라트리스.SetActive(true);
        에이든트리스.SetActive(false);
    }
    public void 에이든트리스정보표기()
    {
        인물정보업데이터();
        DataBaseManager.에이든알리미 = false;
        노아.SetActive(false);
        멜리사.SetActive(false);
        엘라트리스.SetActive(false);
        에이든트리스.SetActive(true);
    }



}
