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


    
    public GameObject 인물창;
    public GameObject 사건창;
    public GameObject 장소창;

    public GameObject 정보창;


    public float 반영체력;
    public float  최초체력;
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
        스트레스게이지사이즈 = 스트레스게이지.GetComponent<RectTransform>();
        상태창켜짐 = false;
        정보창켜짐 = false;
        반영체력 = 1;
        최초체력 = DataBaseManager.체력;
        단위체력 = 1 / 최초체력;


        반영이성 = 1;
        최초이성 = DataBaseManager.정신력;
        단위이성 = 1 / 최초이성;

    }

    public void 상태창켜기()
    {
        정보창.SetActive(true);
        itemMenuNum = 1;
    }
    

    // Update is called once per frame
    void Update()
    {
        확인용스탯생성();
        체력바관리();
        체력감소();
        이성감소();
        메뉴창();
        메뉴창업데이터();
        아이템설명업데이터();
        방향키로조정법();

    }


    public GameObject 상태스탯창;
    public GameObject 보유장비;
    public GameObject 보유기술;

    public void 상태스탯창켜기()
    {
        상태스탯창.SetActive(true);
        보유장비.SetActive(false);
        보유기술.SetActive(false);
    }

    public void 보유장비켜기()
    {
        itemMenuNum = 1;
        상태스탯창.SetActive(false);
        보유장비.SetActive(true);
        보유기술.SetActive(false);
    }
    public void 보유기술켜기()
    {
        상태스탯창.SetActive(false);
        보유장비.SetActive(false);
        보유기술.SetActive(true);

    }

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






    // //////////////////////////////////////////////////////// 아이탬창 관리

    int itemMenuNum = 1;

    public GameObject white1;
    public GameObject white2;
    public GameObject white3;
    public GameObject white4;
    public GameObject white5;
    public GameObject white6;
    public GameObject white7;
    public GameObject white8; 
    public GameObject white9;
    public GameObject white10;
    public GameObject white11;
    public GameObject white12;
    public GameObject white13;
    public GameObject white14;
    public GameObject white15;
    public GameObject white16;
    public GameObject white17;
    public GameObject white18;
    public GameObject white19;
    public GameObject white20;

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
        인물정보창.상태창_보유기술_반영하기();
        Time.timeScale = 0;
        상태창s.SetActive(true);
        상태창켜짐 = true;
    }
    public void 상태창off()
    {
        상태창켜짐 = false;
        Time.timeScale = 1;
        상태창s.SetActive(false);
    }
    void 메뉴창()
    {
        
    

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(itemMenuNum == 20)
            {
                itemMenuNum = 1;
            }

            else
            {
                itemMenuNum = itemMenuNum + 1;
            }


        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (itemMenuNum == 1)
            {
                itemMenuNum = 16;
            }
            else if (itemMenuNum == 2)
            {
                itemMenuNum = 17;
            }
            else if (itemMenuNum == 3)
            {
                itemMenuNum = 18;
            }
            else if (itemMenuNum == 4)
            {
                itemMenuNum = 19;
            }
            else if (itemMenuNum == 5)
            {
                itemMenuNum = 20;
            }
            else
            {
                itemMenuNum = itemMenuNum - 5;
            }


        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (itemMenuNum == 16)
            {
                itemMenuNum = 1;
            }
            else if (itemMenuNum == 17)
            {
                itemMenuNum = 2;
            }
            else if (itemMenuNum == 18)
            {
                itemMenuNum = 3;
            }
            else if (itemMenuNum == 19)
            {
                itemMenuNum = 4;
            }
            else if (itemMenuNum == 20)
            {
                itemMenuNum = 5;
            }
          
            else
            {
                itemMenuNum = itemMenuNum + 5;
            }


        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (itemMenuNum == 1)
            {
                itemMenuNum = 20;
            }

            else
            {
                itemMenuNum = itemMenuNum - 1;
            }
        }


        


    }
    public void 정보창켜기()
    {
        Time.timeScale = 0;
        정보창켜짐 = true;
        정보창.SetActive(true);
    }
    public void 정보창끄기()
    {
        Time.timeScale = 1;
        정보창켜짐 = false;
        정보창.SetActive(false);
    }

    public void 인물창켜기()
    {
        인물창.SetActive(true);
        사건창.SetActive(false);
        장소창.SetActive(false);
    }

    public void 사건창켜기()
    {
        인물창.SetActive(false);
        사건창.SetActive(true);
        장소창.SetActive(false);
    }
    public void 장소창켜기()
    {
        인물창.SetActive(false);
        사건창.SetActive(false);
        장소창.SetActive(true);
    }


    public bool 정보창켜짐 = false;
    void 방향키로조정법()
    {
        if (상태창s.activeSelf == false&& 상태창켜짐 == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                정보창끄기();
                상태창on();
            }
        }

        else if (상태창s.activeSelf == true && 상태창켜짐 == true)
        {
            if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.Escape))
            {
                상태창off();
            }
        }

         if (상태창켜짐 == true)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                상태스탯창켜기();

            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                보유장비켜기();
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                보유기술켜기();
            }

        }

         // 정보창관리
        if (정보창.activeSelf == false && 정보창켜짐 == false)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                상태창off();
                정보창켜기();
            }
        }

        else if (정보창.activeSelf == true && 정보창켜짐 == true)
        {
            if (Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.Escape))
            {
                정보창끄기();
            }
        }

        if (정보창켜짐 == true)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                인물창켜기();

            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                사건창켜기();
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                장소창켜기();
            }

        }
        // 숫자 1234 로 인물창 조정.
        if(정보창켜짐 == true)
        {
            if (인물창.activeSelf == true)
            {
                정보창스크롤속도조정(노아오브젝트, 노아렉트, 노아scrolrect);
                정보창스크롤속도조정(멜리사오브젝트, 멜리사렉트, 멜리사scrolrect);
                정보창스크롤속도조정(엘라오브젝트, 엘라사렉트, 엘라scrolrect);
                정보창스크롤속도조정(에이든오브젝트, 에이든사렉트, 에이든scrolrect);
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    번호에맞는인물창확인(1);
                    인물사건장소스크롤랙트원위치();

                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    번호에맞는인물창확인(2);
                    인물사건장소스크롤랙트원위치();


                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    번호에맞는인물창확인(3);
                    인물사건장소스크롤랙트원위치();

                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    번호에맞는인물창확인(4);
                    인물사건장소스크롤랙트원위치();

                }


            }
            if (사건창.activeSelf == true)
            {
                정보창스크롤속도조정(악몽오브젝트, 악몽렉트, 악몽scrolrect);
                정보창스크롤속도조정(행성대직렬오브젝트, 행성대직렬렉트, 행성대직렬scrolrect);
                정보창스크롤속도조정(편집증오브젝트, 편집증렉트, 편집증scrolrect);
                정보창스크롤속도조정(에이든오브젝트, 에이든사렉트, 에이든scrolrect);
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    번호에맞는사건창확인(1);
                    인물사건장소스크롤랙트원위치();

                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    번호에맞는사건창확인(2);
                    인물사건장소스크롤랙트원위치();


                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    번호에맞는사건창확인(3);
                    인물사건장소스크롤랙트원위치();

                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    번호에맞는사건창확인(4);
                    인물사건장소스크롤랙트원위치();

                }


            }

            if (장소창.activeSelf == true)
            {
                정보창스크롤속도조정(탐정사무소오브젝트, 탐정사무소렉트, 탐정사무소scrolrect);
                정보창스크롤속도조정(아캄시병원오브젝트, 아캄시병원렉트, 아캄시병원scrolrect);
                정보창스크롤속도조정(신문사오브젝트, 신문사렉트, 신문사scrolrect);
                정보창스크롤속도조정(의뢰자의집오브젝트, 의뢰자의집렉트, 의뢰자의집scrolrect);
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    번호에맞는장소창확인(1);
                    인물사건장소스크롤랙트원위치();

                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    번호에맞는장소창확인(2);
                    인물사건장소스크롤랙트원위치();


                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    번호에맞는장소창확인(3);
                    인물사건장소스크롤랙트원위치();

                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    번호에맞는장소창확인(4);
                    인물사건장소스크롤랙트원위치();

                }


            }
        }
    }


    

    void 번호에맞는인물창확인(int num)
    {

        if (인물창.transform.GetChild(num).name == "노아")
        {
            인물사건장소스크롤랙트원위치();
            인물정보창.노아정보표기();
        }
        if (인물창.transform.GetChild(num).name == "멜리사")
        {
            인물사건장소스크롤랙트원위치();
            인물정보창.멜리사정보표기();
        }
        if (인물창.transform.GetChild(num).name == "엘라트리스")
        {
            인물사건장소스크롤랙트원위치();
            인물정보창.엘라트리스정보표기();
        }
        if (인물창.transform.GetChild(num).name == "에이든트리스")
        {
            인물사건장소스크롤랙트원위치();
            인물정보창.에이든트리스정보표기();
        }
    }
    void 번호에맞는사건창확인(int num)
    {

        if (사건창.transform.GetChild(num).name == "악몽")
        {
            인물사건장소스크롤랙트원위치();
            사건정보창.악몽정보표기();
        }
        if (사건창.transform.GetChild(num).name == "행성대직렬")
        {
            인물사건장소스크롤랙트원위치();
            사건정보창.행성대직렬정보표기();
        }
        if (사건창.transform.GetChild(num).name == "편집증")
        {
            인물사건장소스크롤랙트원위치();
            사건정보창.편집증정보표기();
        }
        if (사건창.transform.GetChild(num).name == "불면증")
        {
            인물사건장소스크롤랙트원위치();
            //인물정보창.에이든트리스정보표기();
        }
    }
    void 번호에맞는장소창확인(int num)
    {

        if (장소창.transform.GetChild(num).name == "탐정사무소")
        {
            인물사건장소스크롤랙트원위치();
            장소정보창.탐정사무소정보표기();
        }
        if (장소창.transform.GetChild(num).name == "아캄시 병원")
        {
            인물사건장소스크롤랙트원위치();
            장소정보창.병원정보표기();
        }
        if (장소창.transform.GetChild(num).name == "데일리뉴스 신문")
        {
            인물사건장소스크롤랙트원위치();
            장소정보창.데일리뉴스신문사정보표기();
        }
        if (장소창.transform.GetChild(num).name == "의뢰자의 집")
        {
            인물사건장소스크롤랙트원위치();
            장소정보창.의뢰자의집정보표기();
        }
    }

    void 정보창스크롤속도조정(GameObject 오브젝트, RectTransform 렉트, ScrollRect 스크롤렉트)
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {

            if (오브젝트.activeSelf == true)
            {          




                스크롤속도 = 1 / 렉트.rect.height;


                for (int i = 1; i < 7; i++)
                {

                    스크롤렉트.normalizedPosition = 스크롤렉트.normalizedPosition + new Vector2(0, -스크롤속도);

                }

            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            if (오브젝트.activeSelf == true)
            {
                스크롤속도 = 1 / 렉트.rect.height;
                for (int i = 1; i < 7; i++)
                {

                    스크롤렉트.normalizedPosition = 스크롤렉트.normalizedPosition + new Vector2(0, +스크롤속도);

                }

            }



        }
    }
       
    float 스크롤속도 = 0.001f;
    void 인물사건장소스크롤랙트원위치()
    {
        노아scrolrect.normalizedPosition = new Vector2(0, 1);
        멜리사scrolrect.normalizedPosition = new Vector2(0, 1);
        엘라scrolrect.normalizedPosition =  new Vector2(0, 1);
        에이든scrolrect.normalizedPosition =  new Vector2(0, 1);

        악몽scrolrect.normalizedPosition = new Vector2(0, 1);
        행성대직렬scrolrect.normalizedPosition = new Vector2(0, 1);
        편집증scrolrect.normalizedPosition =  new Vector2(0, 1);

        
        탐정사무소scrolrect.normalizedPosition =  new Vector2(0, 1);
        신문사scrolrect.normalizedPosition =  new Vector2(0, 1);
        아캄시병원scrolrect.normalizedPosition =  new Vector2(0, 1);
        의뢰자의집scrolrect.normalizedPosition = new Vector2(0, 1);
        
    }
    //스크롤랙트, 정보창 전용

    public 인물정보창 인물정보창;
    public 사건정보창 사건정보창;
    public 장소정보창 장소정보창;

    //인물관련 오브젝트,렉트,스크롤렉트
    public ScrollRect 노아scrolrect;
    public GameObject 노아오브젝트;
    public RectTransform 노아렉트;
    public ScrollRect 멜리사scrolrect;
    public GameObject 멜리사오브젝트;
    public RectTransform 멜리사렉트;
    public ScrollRect 엘라scrolrect;
    public GameObject 엘라오브젝트;
    public RectTransform 엘라사렉트;
    public ScrollRect 에이든scrolrect;
    public GameObject 에이든오브젝트;
    public RectTransform 에이든사렉트;


    //사건관련 오브젝트,렉트,스크롤렉트
    public GameObject 악몽오브젝트;
    public GameObject 행성대직렬오브젝트;
    public GameObject 편집증오브젝트;
    public ScrollRect 악몽scrolrect;
    public ScrollRect 행성대직렬scrolrect;
    public ScrollRect 편집증scrolrect;
    public RectTransform 악몽렉트;
    public RectTransform 행성대직렬렉트;
    public RectTransform 편집증렉트;

    //장소관련 오브젝트,렉트,스크롤렉트

    public GameObject 탐정사무소오브젝트;
    public GameObject 아캄시병원오브젝트;
    public GameObject 신문사오브젝트;
    public GameObject 의뢰자의집오브젝트;
    public ScrollRect 탐정사무소scrolrect;
    public ScrollRect 아캄시병원scrolrect;
    public ScrollRect 신문사scrolrect;
    public ScrollRect 의뢰자의집scrolrect;
    public RectTransform 탐정사무소렉트;
    public RectTransform 아캄시병원렉트;
    public RectTransform 신문사렉트;
    public RectTransform 의뢰자의집렉트;


    // 인벤토리에 들어갈 템들은 여기에 넣어둬야함
    public GameObject 무기류배경칸;
    public GameObject 일반배경칸;
    public GameObject 열쇠;
    public GameObject 자동권총;
    public GameObject 인벤토리그리드;



    void 아이템설명초기회()
    {
        무기류배경칸.SetActive(false);
        일반배경칸.SetActive(false);
        자동권총.SetActive(false);
        열쇠.SetActive(false);
    }
    void 아이템설명업데이터()
    {
        if(itemMenuNum ==1)
        {
            if (인벤토리그리드.transform.GetChild(0).name == "총")
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(0).name == "열쇠")
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }

        }
        if (itemMenuNum == 2)
        {
            if (인벤토리그리드.transform.GetChild(1).name == "총")
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(1).name == "열쇠")
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }

        }
    }







    void 메뉴창업데이터()
    {
        if (itemMenuNum == 1)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);
            
            white1.SetActive(true);

        }

        if (itemMenuNum == 2)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white2.SetActive(true);
        }

        if (itemMenuNum == 3)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white3.SetActive(true);
        }

        if (itemMenuNum == 4)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white4.SetActive(true);
        }

        if (itemMenuNum == 5)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white5.SetActive(true);
        }

        if (itemMenuNum == 6)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white6.SetActive(true);
        }

        if (itemMenuNum == 7)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white7.SetActive(true);
        }

        if (itemMenuNum == 8)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white8.SetActive(true);
        }

        if (itemMenuNum == 9)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white9.SetActive(true);
        }

        if (itemMenuNum == 10)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white10.SetActive(true);
        }
        if (itemMenuNum == 11)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white11.SetActive(true);
        }
        if (itemMenuNum == 12)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white12.SetActive(true);
        }
        if (itemMenuNum == 13)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white13.SetActive(true);
        }
        if (itemMenuNum == 14)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white14.SetActive(true);
        }
        if (itemMenuNum == 15)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white15.SetActive(true);
        }
        if (itemMenuNum == 16)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white16.SetActive(true);
        }
        if (itemMenuNum == 17)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white17.SetActive(true);
        }
        if (itemMenuNum == 18)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white18.SetActive(true);
        }
        if (itemMenuNum == 19)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white19.SetActive(true);
        }
        if (itemMenuNum == 20)
        {
            white1.SetActive(false);
            white2.SetActive(false);
            white3.SetActive(false);
            white4.SetActive(false);
            white5.SetActive(false);
            white6.SetActive(false);
            white7.SetActive(false);
            white8.SetActive(false);
            white9.SetActive(false);
            white10.SetActive(false);
            white11.SetActive(false);
            white12.SetActive(false);
            white13.SetActive(false);
            white14.SetActive(false);
            white15.SetActive(false);
            white16.SetActive(false);
            white17.SetActive(false);
            white18.SetActive(false);
            white19.SetActive(false);
            white20.SetActive(false);

            white20.SetActive(true);
        }
    }


    void 스트레스게이지관리()
    {
        스트레스게이지사이즈.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 246.315f - ((9 - DataBaseManager.스트레스게이지) * 20f));
    }

    void 체력감소()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            DataBaseManager.현재체력 -= 1;

            반영체력 = 반영체력 - 단위체력;

            체력바.fillAmount = 반영체력;

        }
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
    void 확인용스탯생성()
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

            힘스킬배분숫자 = DataBaseManager.힘 ;
            지능스킬배분숫자 = DataBaseManager.지능 ;
            민첩스킬배분숫자 = DataBaseManager.민첩 ;
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
