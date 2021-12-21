using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mapManager : MonoBehaviour
{
    public GameObject 페이드이미지오브젝트;
    public Image 페이드이미지;


    public void 시간이동으로씬전환()
    {


        if(DataBaseManager.시간대 == 1)
        {
            DataBaseManager.시간대 += 1;
            SceneManager.LoadScene("02_예비");
        }
        else if (DataBaseManager.시간대 == 2)
        {
            DataBaseManager.시간대 += 1;
            SceneManager.LoadScene("03_예비");
        }
        else if (DataBaseManager.시간대 == 3)
        {
            DataBaseManager.시간대 += 1;
            SceneManager.LoadScene("04_예비");
        }
        else if (DataBaseManager.시간대 == 4)
        {
            SceneManager.LoadScene("1st_Mor_MyROOM_1일차종료");
        }
    }

    public void 페이드아웃()
    {
        StartCoroutine(페이드아웃코루틴());
    }

    IEnumerator 페이드아웃코루틴()
    {
        페이드이미지오브젝트.SetActive(true);
        float 페이드카운트 = 0;
        while(페이드카운트 < 1.0f)
        {
            페이드카운트 += 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);


        }


        시간이동으로씬전환();
    }



    bool isPlaying = false;
    public GameObject 이동확인알람;
    public Text 이동확인텍스트;


    public void 탐정사무소버튼()
    {
        이동확인텍스트.text = "<탐정사무소>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "탐정사무소";
    }

    public void 대학버튼()
    {
        이동확인텍스트.text = "<대학>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "대학";
    }
    public void 경찰서버튼()
    {
        이동확인텍스트.text = "<경찰서>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "경찰서";
    }
    public void 빈민가버튼()
    {
        이동확인텍스트.text = "<빈민가>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "빈민가";
    }
    public void 강가버튼()
    {
        이동확인텍스트.text = "<강가>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "강가";
    }
    public void 의뢰자버튼()
    {
        이동확인텍스트.text = "<의뢰자의집>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "의뢰자의집";
    }
    public void 신문사버튼()
    {
        이동확인텍스트.text = "<신문사>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "신문사";
    }
    public void 술집버튼()
    {
        이동확인텍스트.text = "<술집>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "술집";
    }
    public void 병원버튼()
    {
        이동확인텍스트.text = "<병원>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "병원";
    }

    public void 총포상버튼()
    {
        이동확인텍스트.text = "<총포상>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "총포상";
    }
    public void 이동()
    {
        페이드아웃();

    }

    public void 이동아니오()
    {
        이동확인알람.SetActive(false);
        DataBaseManager.이동지 = "";
    }


   

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
