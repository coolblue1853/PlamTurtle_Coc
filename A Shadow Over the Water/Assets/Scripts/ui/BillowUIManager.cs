using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BillowUIManager : MonoBehaviour
{

    public Image 체력바;
    public Image 이성바;
    public PlayerStat 플레이어스탯생성기;

    public Text 체력텍스트;
    public Text 정신력텍스트;

    public GameObject 정보창;

    public float 반영체력;
    public float  최초체력;
    public float 단위체력;


    public float 반영이성;
    public float 최초이성;
    public float 단위이성;

    public GameObject 스트레스게이지;
    RectTransform 스트레스게이지사이즈;

    // Start is called before the first frame update
    void Start()
    {
        스트레스게이지사이즈 = 스트레스게이지.GetComponent<RectTransform>();

        반영체력 = 1;
        최초체력 = DataBaseManager.체력;
        단위체력 = 1 / 최초체력;


        반영이성 = 1;
        최초이성 = DataBaseManager.정신력;
        단위이성 = 1 / 최초이성;

    }

    public void 상태창켜기()
    {

    }
    public void 정보창켜기()
    {
        정보창.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        확인용스탯생성();
        체력바관리();
        체력감소();
        이성감소();
    }



    void 스트레스게이지관리()
    {
        스트레스게이지사이즈.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 246.315f - ((9 - DataBaseManager.스트레스게이지) * 20f));
    }

    void 체력감소()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            DataBaseManager.현재체력 -= 1;
            반영체력 = 반영체력 - 단위체력;

            체력바.fillAmount = 반영체력;

        }
    }
    void 이성감소()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DataBaseManager.현재정신력 -= 1;
            반영이성 = 반영이성 - 단위이성;

            이성바.color = new Color(1, 1, 1, 반영이성);


        }
    }

    void 체력바관리()
    {
        체력텍스트.text = "체력 : " + DataBaseManager.체력;
        정신력텍스트.text = "정신력 : " + DataBaseManager.정신력;


        //체력 깍는 함수


        
        //이성 1 깍는함수




    }


    //나중에 지워줘야됨
    void 확인용스탯생성()
    {



        int 힘스킬배분숫자;
        int 지능스킬배분숫자;
        int 민첩스킬배분숫자;
        if (Input.GetKeyDown(KeyCode.O))
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

            힘스킬배분숫자 = DataBaseManager.힘 * 2;
            지능스킬배분숫자 = DataBaseManager.지능 * 2;
            민첩스킬배분숫자 = DataBaseManager.민첩 * 2;
            반영체력 = 1;
            최초체력 = DataBaseManager.체력;
            단위체력 = 1 / 최초체력;


            반영이성 = 1;
            최초이성 = DataBaseManager.정신력;
            단위이성 = 1 / 최초이성;

            스트레스게이지관리();
            int 뭘배분 = 0;
            while (0 < 힘스킬배분숫자)
            {
                뭘배분 = Random.Range(1, 9);

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
                        DataBaseManager.고문술 += 1;
                        break;
                    case 5:
                        DataBaseManager.눈썰미 += 1;
                        break;
                    case 6:
                        DataBaseManager.언변술_협박 += 1;
                        break;
                    case 7:
                        DataBaseManager.던지기 += 1;
                        break;
                    case 8:
                        DataBaseManager.잠수 += 1;
                        break;
                }

                힘스킬배분숫자 = 힘스킬배분숫자 - 1;

            }


            int 뭘배분1 = 0;
            while (0 < 지능스킬배분숫자)
            {
                뭘배분 = Random.Range(1, 9);
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
                        DataBaseManager.언변술_설득 += 1;
                        break;
                    case 7:
                        DataBaseManager.붕대감기 += 1;
                        break;
                    case 8:
                        DataBaseManager.법의학 += 1;
                        break;
                }

                지능스킬배분숫자 = 지능스킬배분숫자 - 1;

            }
            int 뭘배분2 = 0;
            while (0 < 민첩스킬배분숫자)
            {
                뭘배분 = Random.Range(1, 9);
                switch (뭘배분2)
                {
                    case 1:
                        DataBaseManager.구르기 += 1;
                        break;
                    case 2:
                        DataBaseManager.변장술 += 1;
                        break;
                    case 3:
                        DataBaseManager.언변술_거짓말 += 1;
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
                    case 7:
                        DataBaseManager.연기술 += 1;
                        break;
                    case 8:
                        DataBaseManager.운동신경 += 1;
                        break;
                }
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
            }

        }



    }



}
