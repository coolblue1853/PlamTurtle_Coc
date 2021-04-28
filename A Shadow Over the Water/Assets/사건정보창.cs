using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 사건정보창 : MonoBehaviour
{
    public GameObject 악몽;
    public GameObject 행성대직렬;
    public GameObject 편집증;

    public GameObject 악몽1;
    public GameObject 악몽2;
    public GameObject 악몽3;
    public GameObject 악몽4;
    public GameObject 악몽5;
    public GameObject 악몽6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        악몽정보업데이트문();

        //임시로 확인용으로 넣어둔 파일, 추후 삭제
        if (Input.GetKeyDown(KeyCode.F1))
        {
            DataBaseManager.악몽정보2 = true;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            DataBaseManager.악몽정보3 = true;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            DataBaseManager.악몽정보4 = true;
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            DataBaseManager.악몽정보5 = true;
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            DataBaseManager.악몽정보6 = true;
        }


    }

    void 악몽정보업데이트문()
    {
        if (DataBaseManager.악몽정보1 == true)
        {
            악몽1.SetActive(true);
        }
        else
        {
            악몽1.SetActive(false);

        }

        if (DataBaseManager.악몽정보2 == true)
        {
            악몽2.transform.SetAsFirstSibling();
            악몽2.SetActive(true);
        }
        else
        {
            악몽2.SetActive(false);

        }

        if (DataBaseManager.악몽정보3 == true)
        {
            악몽3.SetActive(true);
        }
        else
        {
            악몽3.SetActive(false);

        }

        if (DataBaseManager.악몽정보4 == true)
        {
            악몽4.SetActive(true);
        }
        else
        {
            악몽4.SetActive(false);

        }

        if (DataBaseManager.악몽정보5 == true)
        {
            악몽5.SetActive(true);
        }
        else
        {
            악몽5.SetActive(false);

        }

        if (DataBaseManager.악몽정보6 == true)
        {
            악몽6.SetActive(true);
        }
        else
        {
            악몽6.SetActive(false);

        }
    }

    public void 노아정보표기()
    {
        악몽.SetActive(true);
        행성대직렬.SetActive(false);
        편집증.SetActive(false);
    }

    public void 멜리사정보표기()
    {
        악몽.SetActive(false);
        행성대직렬.SetActive(true);
        편집증.SetActive(false);
    }
    public void 나르댕정보표기()
    {
        악몽.SetActive(false);
        행성대직렬.SetActive(false);
        편집증.SetActive(true);
    }

}
