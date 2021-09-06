using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleUiManager : MonoBehaviour
{

    public Image 체력바;
    public Image 이성바;
    public PlayerStat 플레이어스탯생성기;

    public Text 체력텍스트;
    public Text 정신력텍스트;



    public GameObject 인물창;
    public GameObject 사건창;
    public GameObject 장소창;

    public GameObject 정보창;


    public float 반영체력;
    public float 최초체력;
    public float 단위체력;


    public float 반영이성;
    public float 최초이성;
    public float 단위이성;

    public GameObject 스트레스게이지;
    RectTransform 스트레스게이지사이즈;

    public bool isItemMenuOn = false;





    // Start is called before the first frame update
    void Start()
    {

        상태창켜짐 = false;

        반영체력 = 1;
        최초체력 = DataBaseManager.체력;
        단위체력 = 1 / 최초체력;


        반영이성 = 1;
        최초이성 = DataBaseManager.정신력;
        단위이성 = 1 / 최초이성;

    }




    // Update is called once per frame
    void Update()
    {
        //확인용스탯생성();
        체력바관리();

        이성감소();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DataBaseManager.구르기 = 6;
            DataBaseManager.맨손격투 = 3;
            DataBaseManager.사격술 = 6;

            DataBaseManager.던지기 = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DataBaseManager.보유권총탄약 = DataBaseManager.보유권총탄약+ 4;
            DataBaseManager.보유리볼버탄약 = DataBaseManager.보유리볼버탄약 + 6;
            DataBaseManager.보유샷건탄약 = DataBaseManager.보유샷건탄약 + 4;
            DataBaseManager.보유소총탄약 = DataBaseManager.보유소총탄약 + 5;
        }
    }


    public GameObject 상태스탯창;
    public GameObject 보유장비;
    public GameObject 보유기술;


    // //////////////////////////////////////////////////////// 상태창창 관리
    public Text 힘텍스트;
    public Text 지능텍스트;
    public Text 민첩텍스트;
    public Text 행운텍스트;
    public Text 활력텍스트;
    public Text 의지력텍스트;
    public Text 마력텍스트;
    public Text 체략텍스트2;
    public Text 정신력텍스트2;
    public Text 스트래스내성텍스트;
    public Text 현재체력텍스트2;
    public Text 현재정신력텍스트2;

    void 상태스탯관리()
    {

    }








    public GameObject 상태창s;
    public bool 상태창켜짐 = false;
    public void 상태창on()
    {

        상태스탯창.SetActive(true);
        보유장비.SetActive(false);
        보유기술.SetActive(false);
        //보유기술.SetActive(false);
        //체력텍스트.text = "체력 : " + DataBaseManager.현재체력;
        현재체력텍스트2.text = "체력 : " + DataBaseManager.현재체력;
        현재정신력텍스트2.text = "정신력 : " + DataBaseManager.현재정신력;

        힘텍스트.text = "힘 : " + DataBaseManager.힘.ToString();
        지능텍스트.text = "지능 : " + DataBaseManager.지능.ToString();
        민첩텍스트.text = "민첩 : " + DataBaseManager.민첩.ToString();
        행운텍스트.text = "행운 : " + DataBaseManager.행운.ToString();

        활력텍스트.text = "활력 : " + DataBaseManager.활력.ToString();
        의지력텍스트.text = "의지력 : " + DataBaseManager.의지력.ToString();
        마력텍스트.text = "마력 : " + DataBaseManager.마력.ToString();

        정신력텍스트2.text = "정신력 : " + DataBaseManager.정신력.ToString();
        체략텍스트2.text = "체력 : " + DataBaseManager.체력.ToString();
        스트래스내성텍스트.text = "스트래스 내성 : " + DataBaseManager.스트레스게이지.ToString();

        Time.timeScale = 0;
        상태창s.SetActive(true);
        상태창켜짐 = true;
    }












    bool first = false;

    public void 체력감소()
    {
        if(first == false)
        {
            반영체력 = 1;
            최초체력 = DataBaseManager.체력;
            단위체력 = 1 / 최초체력;
            first = true;
        }




            DataBaseManager.현재체력 -= 1;

            반영체력 = 반영체력 - 단위체력;

            체력바.fillAmount = 반영체력;

    }
    void 이성감소()
    {
        if (Input.GetKeyDown(KeyCode.Question))
        {
            DataBaseManager.현재정신력 -= 1;

            반영이성 = 반영이성 - 단위이성;

            이성바.color = new Color(1, 1, 1, 반영이성);


        }
    }

    void 체력바관리()
    {
        체력텍스트.text = "체력 : " + DataBaseManager.현재체력;
        정신력텍스트.text = "정신력 : " + DataBaseManager.현재정신력;


        //체력 깍는 함수



        //이성 1 깍는함수




    }





    //나중에 지워줘야됨
    public void 확인용스탯생성()
    {



        int 힘스킬배분숫자;
        int 지능스킬배분숫자;
        int 민첩스킬배분숫자;
        if (Input.GetKeyDown(KeyCode.F12))
        {
            DataBaseManager.힘 = Random.Range(1, 10);
            DataBaseManager.지능 = Random.Range(1, 10);
            DataBaseManager.민첩 = Random.Range(1, 10);
            DataBaseManager.행운 = Random.Range(1, 10);

            DataBaseManager.활력 = Random.Range(1, 10);
            DataBaseManager.마력 = Random.Range(1, 10);
            DataBaseManager.의지력 = Random.Range(1, 10);

            DataBaseManager.체력 = DataBaseManager.활력 + DataBaseManager.의지력;
            DataBaseManager.정신력 = DataBaseManager.마력 + DataBaseManager.의지력;

            DataBaseManager.현재체력 = DataBaseManager.체력;
            DataBaseManager.현재정신력 = DataBaseManager.정신력;

            DataBaseManager.스트레스게이지 = DataBaseManager.의지력;

            힘스킬배분숫자 = DataBaseManager.힘;
            지능스킬배분숫자 = DataBaseManager.지능;
            민첩스킬배분숫자 = DataBaseManager.민첩;
            반영체력 = 1;
            최초체력 = DataBaseManager.체력;
            단위체력 = 1 / 최초체력;


            반영이성 = 1;
            최초이성 = DataBaseManager.정신력;
            단위이성 = 1 / 최초이성;


            int 뭘배분 = 0;
            while (0 < 힘스킬배분숫자)
            {
                뭘배분 = Random.Range(1, 7);

                switch (뭘배분)
                {
                    case 1:
                        DataBaseManager.맨손격투 += 1;
                        break;
                    case 2:
                        DataBaseManager.사격술 += 1;
                        break;
                    case 3:
                        DataBaseManager.검술 += 1;
                        break;

                    case 4:
                        DataBaseManager.눈썰미 += 1;
                        break;

                    case 5:
                        DataBaseManager.던지기 += 1;
                        break;
                    case 6:
                        DataBaseManager.잠수 += 1;
                        break;
                }

                힘스킬배분숫자 = 힘스킬배분숫자 - 1;

            }


            int 뭘배분1 = 0;
            while (0 < 지능스킬배분숫자)
            {
                뭘배분1 = Random.Range(1, 7);
                switch (뭘배분1)
                {
                    case 1:
                        DataBaseManager.의학지식 += 1;
                        break;
                    case 2:
                        DataBaseManager.정보조사 += 1;
                        break;
                    case 3:
                        DataBaseManager.심리판단 += 1;
                        break;
                    case 4:
                        DataBaseManager.오컬트지식 += 1;
                        break;
                    case 5:
                        DataBaseManager.정신감정 += 1;
                        break;
                    case 6:
                        DataBaseManager.붕대감기 += 1;
                        break;

                }

                지능스킬배분숫자 = 지능스킬배분숫자 - 1;

            }
            int 뭘배분2 = 0;
            while (0 < 민첩스킬배분숫자)
            {
                뭘배분2 = Random.Range(1, 7);
                switch (뭘배분2)
                {
                    case 1:
                        DataBaseManager.구르기 += 1;
                        break;
                    case 2:
                        DataBaseManager.변장술 += 1;
                        break;
                    case 3:
                        DataBaseManager.언변술 += 1;
                        break;
                    case 4:
                        DataBaseManager.자물쇠따기 += 1;
                        break;
                    case 5:
                        DataBaseManager.손재주 += 1;
                        break;
                    case 6:
                        DataBaseManager.은신 += 1;
                        break;

                }
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
            }

        }



    }



}
