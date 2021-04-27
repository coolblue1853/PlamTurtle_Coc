using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 인물정보창 : MonoBehaviour
{
    public GameObject 노아;
    public GameObject 멜리사;
    public GameObject 나르댕;

    public GameObject 노아1;
    public GameObject 노아2;
    public GameObject 노아3;
    public GameObject 노아4;
    public GameObject 노아5;
    public GameObject 노아6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        노아정보업데이트문();

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

    public void 노아정보표기()
    {
        노아.SetActive(true);
        멜리사.SetActive(false);
        나르댕.SetActive(false);
    }

    public void 멜리사정보표기()
    {
        노아.SetActive(false);
        멜리사.SetActive(true);
        나르댕.SetActive(false);
    }
    public void 나르댕정보표기()
    {
        노아.SetActive(false);
        멜리사.SetActive(false);
        나르댕.SetActive(true);
    }

}
