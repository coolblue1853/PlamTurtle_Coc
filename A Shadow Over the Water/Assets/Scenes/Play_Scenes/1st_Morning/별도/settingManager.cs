using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class settingManager : MonoBehaviour
{

    public GameObject 의뢰자의집;
    public GameObject 총포상;
    public GameObject 탐정사무소;
    public GameObject 병원;
    public GameObject 경찰서;
    public GameObject 신문사;
    public GameObject 강가;
    public GameObject 대학교;
    public GameObject 술집;
    public GameObject 빈민가;
    public void 지도버튼모두켜기()
    {
        의뢰자의집.SetActive(true);
        총포상.SetActive(true);
        탐정사무소.SetActive(true);
        병원.SetActive(true);
        경찰서.SetActive(true);
        신문사.SetActive(true);
        강가.SetActive(true);
        대학교.SetActive(true);
        술집.SetActive(true);
        빈민가.SetActive(true);
    }
    public void 지도버튼모두끄기()
    {
        의뢰자의집.SetActive(false);
        총포상.SetActive(false);
        탐정사무소.SetActive(false);
        병원.SetActive(false);
        경찰서.SetActive(false);
        신문사.SetActive(false);
        강가.SetActive(false);
        대학교.SetActive(false);
        술집.SetActive(false);
        빈민가.SetActive(false);
    }
    public void 지도업데이터()  // 장소에 따라, 시간에 따라 갈수있는곳 없는곳을 지정해주는 지도업데이터
    {
        

        if (SceneManager.GetActiveScene().name == "1st_Mor_Slum")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            빈민가.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "1st_Mor_MyROOM")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            탐정사무소.SetActive(false);

            if (DataBaseManager.시간대 % 4 == 0)
            {
                지도켜기버튼.SetActive(false);

            }
        }
        else if (SceneManager.GetActiveScene().name == "1st_Mor_Uni")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            대학교.SetActive(false);
        }

        else if (SceneManager.GetActiveScene().name == "1st_Mor_GUNSHOP")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            총포상.SetActive(false);
        }

        else if(SceneManager.GetActiveScene().name == "1st_Mor_Police")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            경찰서.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().name == "1st_Mor_river")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            강가.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().name == "1st_Mor_questHouse")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            의뢰자의집.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().name == "1st_Mor_NewsPaper")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            신문사.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().name == "1st_Mor_Bar")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            술집.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().name == "1st_Mor_Hospital")
        {
            지도버튼모두켜기();
            술집.SetActive(false);
            병원.SetActive(false);
        }

        if(DataBaseManager.시간대 %4 == 3)
        {
            지도버튼모두끄기();
            강가.SetActive(true);
            술집.SetActive(true);
            탐정사무소.SetActive(true);
        }

    }
    public GameObject 지도켜기버튼;
    public GameObject 일과종료버튼;


    public GameObject 지도창;
    public GameObject 하부창;
    public GameObject 상부창;
    public GameObject 대화창활성화여부;
    public void 지도켜기()
    {
        지도업데이터();
        if (대화창활성화여부.activeSelf == false)
        {
            DataBaseManager.옵션창여부 = true;
            지도창.SetActive(true);
            하부창.SetActive(true);
            상부창.SetActive(false);
        }
    }
    public void 지도끄기()
    {
        DataBaseManager.옵션창여부 = false;
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
        if (DataBaseManager.옵션창여부 == false)
        {
            DataBaseManager.옵션창여부 = true;
            Time.timeScale = 0;
            옵션창.SetActive(true);

        }




    }
    public void 처음으로버튼()
    {
        설정창끄기();
        SceneManager.LoadScene("SetCharacter");
    }
    public void 게임종료버튼()
    {
        설정창끄기();
        Application.Quit();
    }
    public void 설정창켜기()
    {
        DataBaseManager.옵션창여부 = true;
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
        DataBaseManager.옵션창여부 = false;
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

        if(DataBaseManager.옵션창여부 == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                설정창끄기();
            }
        }
        
        
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
