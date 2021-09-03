using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 사건정보창 : MonoBehaviour
{
    public GameObject 악몽;
    public GameObject 행성대직렬;
    public GameObject 편집증;
    public GameObject 불면증;

    public GameObject 악몽1;
    public GameObject 악몽2;
    public GameObject 악몽3;
    public GameObject 악몽4;
    public GameObject 악몽5;
    public GameObject 악몽6;


    public GameObject 행성대직렬1;
    public GameObject 편집증1;
    public GameObject 불면증1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    void 정보업데이트_사건()
    {
        악몽정보업데이트문();
        행성대직렬정보업데이트문();
        불면증정보업데이트문();
        편집증정보업데이트문();
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


    void 행성대직렬정보업데이트문()
    {
        if (DataBaseManager.행성대직렬정보1 == true)
        {
            행성대직렬1.SetActive(true);
        }
        else
        {
            행성대직렬1.SetActive(false);

        }
    }



    void 불면증정보업데이트문()
    {
        if (DataBaseManager.불면증정보1 == true)
        {
            불면증1.SetActive(true);
        }
        else
        {
            불면증1.SetActive(false);

        }
    }



    void 편집증정보업데이트문()
    {
        if (DataBaseManager.편집증정보1 == true)
        {
            편집증1.SetActive(true);
        }
        else
        {
            편집증1.SetActive(false);

        }
    }



    public void 사건정보초기화()
    {
        악몽.SetActive(false);
        행성대직렬.SetActive(false);
        편집증.SetActive(false);
        불면증.SetActive(false);
    }






    public void 악몽정보표기()
    {
        정보업데이트_사건();
        DataBaseManager.악몽알리미 = false;
        악몽.SetActive(true);
        행성대직렬.SetActive(false);
        편집증.SetActive(false);
        불면증.SetActive(false);
    }

    public void 행성대직렬정보표기()
    {
        정보업데이트_사건();
        DataBaseManager.행성대직렬알리미 = false;
        악몽.SetActive(false);
        행성대직렬.SetActive(true);
        편집증.SetActive(false);
        불면증.SetActive(false);
    }
    public void 편집증정보표기()
    {
        정보업데이트_사건();
        DataBaseManager.편집증알리미 = false;
        악몽.SetActive(false);
        행성대직렬.SetActive(false);
        편집증.SetActive(true);
        불면증.SetActive(false);
    }
    public void 불면증정보표기()
    {
        정보업데이트_사건();
        DataBaseManager.불면증알리미 = false;
        악몽.SetActive(false);
        행성대직렬.SetActive(false);
        편집증.SetActive(false);
        불면증.SetActive(true);
    }
}
