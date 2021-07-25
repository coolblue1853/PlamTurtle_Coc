using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 텍스트속도 : MonoBehaviour
{
    public Text 타이핑속도;
    int 타이핑속도인트 = 3;

    public void 타이핑인트업()
    {
        if (타이핑속도인트 == 5)
        {
            타이핑속도인트 = 1;
        }
        else
        {
            타이핑속도인트++;
        }
    }

    public void 타이핑인트다운()
    {
        if (타이핑속도인트 == 1)
        {
            타이핑속도인트 = 5;
        }
        else
        {
            타이핑속도인트--;
        }
    }

    public void 글자속도업데이터()
    {
        if (타이핑속도인트 == 1)
        {
            DataBaseManager.텍스트딜레이 = 0.06f;
            타이핑속도.text = "아주 느림";
        }
        else if (타이핑속도인트 == 2)
        {
            DataBaseManager.텍스트딜레이 = 0.04f;
            타이핑속도.text = "느 림";
        }
        else if (타이핑속도인트 == 3)
        {
            DataBaseManager.텍스트딜레이 = 0.02f;
            타이핑속도.text = "보 통";
        }
        else if (타이핑속도인트 == 4)
        {
            DataBaseManager.텍스트딜레이 = 0.01f;
            타이핑속도.text = "빠 름";
        }
        else if (타이핑속도인트 == 5)
        {
            DataBaseManager.텍스트딜레이 = 0.001f;
            타이핑속도.text = "아주 빠름";
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DataBaseManager.스킵활성화 == false)
        {
            글자속도업데이터();
        }


    }
}
