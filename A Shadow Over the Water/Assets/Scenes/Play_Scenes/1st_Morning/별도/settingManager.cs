using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class settingManager : MonoBehaviour
{
  


    public GameObject 지도창;
    public GameObject 하부창;
    public GameObject 상부창;
    public GameObject 대화창활성화여부;
    public void 지도켜기()
    {
        if (대화창활성화여부.activeSelf == false)
        {
            지도창.SetActive(true);
            하부창.SetActive(true);
            상부창.SetActive(false);
        }
    }
    public void 지도끄기()
    {
        지도창.SetActive(false);
        하부창.SetActive(false);
        상부창.SetActive(false);
    }
    public void 지도상부로()
    {
        지도창.SetActive(true);
        하부창.SetActive(false);
        상부창.SetActive(true);
    }
    public void 지도하부로()
    {
        지도창.SetActive(true);
        하부창.SetActive(true);
        상부창.SetActive(false);
    }

    // Start is called before the first frame update
    public GameObject 옵션창;
    public GameObject 설정창;
    public void 옵션창켜기()
    {
        Time.timeScale = 0;
            옵션창.SetActive(true);


    }
    public void 설정창켜기()
    {
        옵션창.SetActive(false);
        설정창.SetActive(true);
    }
    public void 설정창뒤로가기()
    {
        옵션창.SetActive(true);
        설정창.SetActive(false);
    }
    public void 설정창끄기()
    {
        Time.timeScale = 1;
        옵션창.SetActive(false);
        설정창.SetActive(false);
    }
    public Text 해상도;
    int 화면체인지인트값 = 1;
    bool 전체화면 = true;

    public void 전체화면온()
    {
        전체화면 = true;
    }
    public void 전체화면오프()
    {
        전체화면 = false;
    }
    public void 화면체인저엔터()
    {
        if (화면체인지인트값 == 0 && 전체화면 == false)
        {
            Screen.SetResolution(2560, 1440, false);
        }
        else if (화면체인지인트값 == 1 && 전체화면 == false)
        {
            Screen.SetResolution(1920, 1080, false);
        }
        else if (화면체인지인트값 == 2 && 전체화면 == false)
        {
            Screen.SetResolution(1600, 900, false);
        }

        else if (화면체인지인트값 == 3 && 전체화면 == false)
        {
            Screen.SetResolution(1280, 720, false);
        }

        else if (화면체인지인트값 == 4 && 전체화면 == false)
        {
            Screen.SetResolution(960, 540, false);
        }

        else if (화면체인지인트값 == 5 && 전체화면 == false)
        {
            Screen.SetResolution(640, 360, false);
        }


        if (화면체인지인트값 == 0 && 전체화면 == true)
        {
            Screen.SetResolution(2560, 1440, true);
        }
        else if (화면체인지인트값 == 1 && 전체화면 == true)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        else if (화면체인지인트값 == 2 && 전체화면 == true)
        {
            Screen.SetResolution(1600, 900, true);
        }

        else if (화면체인지인트값 == 3 && 전체화면 == true)
        {
            Screen.SetResolution(1280, 720, true);
        }

        else if (화면체인지인트값 == 4 && 전체화면 == true)
        {
            Screen.SetResolution(960, 540, true);
        }

        else if (화면체인지인트값 == 5 && 전체화면 == true)
        {
            Screen.SetResolution(640, 360, true);
        }
    }

    public void 인트더하기()
    {
        화면체인지인트값++;
    }

    public void 빼기()
    {
        화면체인지인트값--;
    }


    void Start()
    {
        
    }

    public GameObject 전체레드;
    public GameObject 창레드;

    // Update is called once per frame
    void Update()
    {


        
        
        if (전체화면 == true)
        {
            전체레드.SetActive(true);
            창레드.SetActive(false);

        }
        else if (전체화면 == false)
        {
            전체레드.SetActive(false);
            창레드.SetActive(true);

        }

        if (화면체인지인트값 == 6)
        {
            화면체인지인트값 = 0;
        }

        if (화면체인지인트값 == 0)
        {
            해상도.text = "2560 x 1440";
        }
        else if (화면체인지인트값 == 1)
        {
            해상도.text = "1920 x 1080";
        }
        else if (화면체인지인트값 == 2)
        {
            해상도.text = "1600 x 900";
        }
        else if (화면체인지인트값 == 3)
        {
            해상도.text = "1280 x 720";
        }
        else if (화면체인지인트값 == 4)
        {
            해상도.text = "960 x 540";
        }
        else if (화면체인지인트값 == 5)
        {
            해상도.text = "640 x 360";
        }

    }
}
