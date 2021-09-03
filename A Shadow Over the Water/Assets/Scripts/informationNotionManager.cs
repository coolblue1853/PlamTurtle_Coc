using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class informationNotionManager : MonoBehaviour
{
    public GameObject 정보창알리미;
    public GameObject 사건창알리미;
    public GameObject 인물창알리미;
    public GameObject 장소창알리미;

    public GameObject 노아알리미;
    public GameObject 멜리사알리미;
    public GameObject 엘라알리미;
    public GameObject 에이든알리미;

    public GameObject 악몽알리미;
    public GameObject 행성대직렬알리미;
    public GameObject 편집증알리미;
    public GameObject 불면증알리미;

    public GameObject 탐정사무소알리미;
    public GameObject 병원알리미;
    public GameObject 신문사알리미;
    public GameObject 의뢰자의집알리미;
    public GameObject 아캄역알리미;


    public void 삭제할버튼()
    {
        SceneManager.LoadScene("1st_Mor_GUNSHOP");
    }


    public void 정보창업데이터()
    {
        if (DataBaseManager.악몽알리미 == false && DataBaseManager.행성대직렬알리미 == false && DataBaseManager.편집증알리미 == false && DataBaseManager.불면증알리미 == false)
        {
            DataBaseManager.사건창알리미 = false;
        }
        else
        {
            DataBaseManager.사건창알리미 = true;
        }


        if (DataBaseManager.노아알리미 == false && DataBaseManager.멜리사알리미 == false && DataBaseManager.엘라알리미 == false && DataBaseManager.에이든알리미 == false)
        {
            DataBaseManager.인물창알리미 = false;
        }
        else
        {
            DataBaseManager.인물창알리미 = true;
        }


        if (DataBaseManager.탐정사무소알리미 == false && DataBaseManager.병원알리미 == false && DataBaseManager.신문사알리미 == false && DataBaseManager.의뢰자의집알리미 == false && DataBaseManager.아캄역알리미 == false)
        {
            DataBaseManager.장소창알리미 = false;
        }
        else
        {
            DataBaseManager.장소창알리미 = true;
        }



        if (DataBaseManager.사건창알리미 == false && DataBaseManager.인물창알리미 == false && DataBaseManager.장소창알리미 == false)
        {
            DataBaseManager.정보창알리미 = false;
        }
        else
        {
            DataBaseManager.정보창알리미 = true;
        }
    }


    public void 정보창알리미업데이터()
    {
        if (DataBaseManager.정보창알리미 == true)
        {
            정보창알리미.SetActive(true);
        }
        else
        {
            정보창알리미.SetActive(false);
        }

        if (DataBaseManager.사건창알리미 == true)
        {
            사건창알리미.SetActive(true);
        }
        else
        {
            사건창알리미.SetActive(false);
        }

        if (DataBaseManager.인물창알리미 == true)
        {
            인물창알리미.SetActive(true);
        }
        else
        {
            인물창알리미.SetActive(false);
        }

        if (DataBaseManager.장소창알리미 == true)
        {
            장소창알리미.SetActive(true);
        }
        else
        {
            장소창알리미.SetActive(false);
        }


        if (DataBaseManager.노아알리미 == true)
        {
            노아알리미.SetActive(true);
        }
        else
        {
            노아알리미.SetActive(false);
        }

        if (DataBaseManager.멜리사알리미 == true)
        {
            멜리사알리미.SetActive(true);
        }
        else
        {
            멜리사알리미.SetActive(false);
        }

        if (DataBaseManager.엘라알리미 == true)
        {
            엘라알리미.SetActive(true);
        }
        else
        {
            엘라알리미.SetActive(false);
        }

        if (DataBaseManager.에이든알리미 == true)
        {
            에이든알리미.SetActive(true);
        }
        else
        {
            에이든알리미.SetActive(false);
        }

        if (DataBaseManager.악몽알리미 == true)
        {
            악몽알리미.SetActive(true);
        }
        else
        {
            악몽알리미.SetActive(false);
        }
        if (DataBaseManager.불면증알리미 == true)
        {
            불면증알리미.SetActive(true);
        }
        else
        {
            불면증알리미.SetActive(false);
        }
        if (DataBaseManager.행성대직렬알리미 == true)
        {
            행성대직렬알리미.SetActive(true);
        }
        else
        {
            행성대직렬알리미.SetActive(false);
        }

        if (DataBaseManager.편집증알리미 == true)
        {
            편집증알리미.SetActive(true);
        }
        else
        {
            편집증알리미.SetActive(false);
        }

        if (DataBaseManager.탐정사무소알리미 == true)
        {
            탐정사무소알리미.SetActive(true);
        }
        else
        {
            탐정사무소알리미.SetActive(false);
        }

        if (DataBaseManager.병원알리미 == true)
        {
            병원알리미.SetActive(true);
        }
        else
        {
            병원알리미.SetActive(false);
        }

        if (DataBaseManager.의뢰자의집알리미 == true)
        {
            의뢰자의집알리미.SetActive(true);
        }
        else
        {
            의뢰자의집알리미.SetActive(false);
        }

        if (DataBaseManager.신문사알리미 == true)
        {
            신문사알리미.SetActive(true);
        }
        else
        {
            신문사알리미.SetActive(false);
        }
        if (DataBaseManager.아캄역알리미 == true)
        {
            아캄역알리미.SetActive(true);
        }
        else
        {
            아캄역알리미.SetActive(false);
        }




    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        정보창알리미업데이터();
        정보창업데이터();
    }
}
