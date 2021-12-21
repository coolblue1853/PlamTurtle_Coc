using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UpperUIManager : MonoBehaviour
{

    public GameObject 이동확인알람;
    public GameObject 페이드이미지오브젝트;
    public Image 페이드이미지;
    public void 일과종료버튼클릭()
    {

        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "";
    }
    public void 일과종료버튼아니오()
    {

        이동확인알람.SetActive(false);

    }
    public void 일과종료버튼예()
    {
        페이드아웃();
  

    }

    public void 시간이동으로씬전환()
    {



        SceneManager.LoadScene("1st_Mor_MyROOM_1일차종료");

    }

    public void 페이드아웃()
    {
        StartCoroutine(페이드아웃코루틴());
    }

    IEnumerator 페이드아웃코루틴()
    {
        페이드이미지오브젝트.SetActive(true);
        float 페이드카운트 = 0;
        while (페이드카운트 < 1.0f)
        {
            페이드카운트 += 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);


        }


        시간이동으로씬전환();
    }

    IEnumerator 페이드인코루틴()
    {

        float 페이드카운트 = 1;
        while (페이드카운트 > 0.0f)
        {
            페이드카운트 -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);


        }

        페이드이미지오브젝트.SetActive(false);

    }


    public GameObject 지도켜기버튼;
    public GameObject 일과종료버튼;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(페이드인코루틴());
        if (DataBaseManager.시간대 % 4 == 0)
        {
            지도켜기버튼.SetActive(false);
            일과종료버튼.SetActive(true);
        }
        else
        {
            지도켜기버튼.SetActive(true);
            일과종료버튼.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
