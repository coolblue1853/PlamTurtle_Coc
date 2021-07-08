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

    public void 노아정보표기()
    {
        노아.SetActive(true);
        멜리사.SetActive(false);
        엘라트리스.SetActive(false);
        에이든트리스.SetActive(false);
    }

    public void 멜리사정보표기()
    {
        노아.SetActive(false);
        멜리사.SetActive(true);
        엘라트리스.SetActive(false);
        에이든트리스.SetActive(false);
    }
    public void 엘라트리스정보표기()
    {
        노아.SetActive(false);
        멜리사.SetActive(false);
        엘라트리스.SetActive(true);
        에이든트리스.SetActive(false);
    }
    public void 에이든트리스정보표기()
    {
        노아.SetActive(false);
        멜리사.SetActive(false);
        엘라트리스.SetActive(false);
        에이든트리스.SetActive(true);
    }



    public Text 맨손격투;
    public Text 사격술;
    public Text 단검술;
    public Text 눈썰미;
    public Text 던지기;
    public Text 잠수;

    public Text 의학지식;
    public Text 정보조사;
    public Text 심리판단;
    public Text 오컬트지식;
    public Text 정신감정;
    public Text 붕대감기;

    public Text 구르기;
    public Text 변장술;
    public Text 자물쇠따기;
    public Text 손재주;
    public Text 은신;
    public Text 언변술;

    public void 상태창_보유기술_반영하기()
    {
        맨손격투.text = "맨손격투 : " + DataBaseManager.맨손격투.ToString();
        사격술.text = "사격술 : " + DataBaseManager.사격술.ToString();
        단검술.text = "단검술 : " + DataBaseManager.검술.ToString();
        눈썰미.text = "눈썰미 : " + DataBaseManager.눈썰미.ToString();
        던지기.text = "던지기 : " + DataBaseManager.던지기.ToString();
        잠수.text = "잠수 : " + DataBaseManager.잠수.ToString();

        의학지식.text = "의학지식 : " + DataBaseManager.의학지식.ToString();
        정보조사.text = "정보조사 : " + DataBaseManager.정보조사.ToString();
        심리판단.text = "심리판단 : " + DataBaseManager.심리판단.ToString();
        오컬트지식.text = "오컬트지식 : " + DataBaseManager.오컬트지식.ToString();
        정신감정.text = "정신감정 : " + DataBaseManager.정신감정.ToString();
        붕대감기.text = "붕대감기 : " + DataBaseManager.붕대감기.ToString();

        구르기.text = "구르기 : " + DataBaseManager.구르기.ToString();
        변장술.text = "변장술 : " + DataBaseManager.변장술.ToString();
        자물쇠따기.text = "자물쇠따기 : " + DataBaseManager.자물쇠따기.ToString();
        손재주.text = "손재주 : " + DataBaseManager.손재주.ToString();
        은신.text = "은신 : " + DataBaseManager.은신.ToString();
        언변술.text = "언변술 : " + DataBaseManager.언변술.ToString();



    }
}
