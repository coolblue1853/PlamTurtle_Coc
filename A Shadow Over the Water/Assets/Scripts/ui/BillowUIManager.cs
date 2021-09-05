using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BillowUIManager : MonoBehaviour
{
    public GameObject 대화창활성화여부;
    public Image 체력바;
    public Image 이성바;


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
        if(대화창활성화여부.activeSelf== false)
        {
            DataBaseManager.옵션창여부 = true;
            정보창.SetActive(true);
            itemMenuNum = 1;
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        인벤토리체커();
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
        if (대화창활성화여부.activeSelf == false)
        {
            DataBaseManager.옵션창여부 = true;
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
    }
    public void 상태창off()
    {
        DataBaseManager.옵션창여부 = false;
        상태창켜짐 = false;
        Time.timeScale = 1;
        상태창s.SetActive(false);
    }
    void 메뉴창()
    {
        
    

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            아이템설명초기회();
            if (itemMenuNum == 20)
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
            아이템설명초기회();
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
            아이템설명초기회();
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
            아이템설명초기회();
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
        if (대화창활성화여부.activeSelf == false)
        {




            DataBaseManager.옵션창여부 = true;
            Time.timeScale = 0;
            정보창켜짐 = true;
            정보창.SetActive(true);
        }
    }
    public void 정보창끄기()
    {

        Time.timeScale = 1;
        정보창켜짐 = false;
        DataBaseManager.옵션창여부 = false;
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
            if (대화창활성화여부.activeSelf == false)
            {
                if (Input.GetKeyDown(KeyCode.I))
                {
                    정보창끄기();
                    상태창on();
                }
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
            if (대화창활성화여부.activeSelf == false)
            {
                if (Input.GetKeyDown(KeyCode.O))
                {
                    상태창off();
                    정보창켜기();
                }
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

     
  
    }


    



    // 인벤토리에 들어갈 템들은 여기에 넣어둬야함
    public GameObject 무기류배경칸;
    public GameObject 일반배경칸;
    public GameObject 단검류배경칸;
    public GameObject 열쇠;


    public GameObject 자동권총;
    public GameObject 인벤토리그리드;


    public GameObject 소형권총이미지;
    public GameObject 리볼버이미지;
    public GameObject 소총이미지;
    public GameObject 샷건이미지;

    public GameObject 몽둥이이미지;
    public GameObject 단검이미지;
    public GameObject 도끼이미지;

    public GameObject 화염병이미지;

    //설명파트
    public GameObject 소형권총설명;
    public GameObject 리볼버설명;
    public GameObject 소총설명;
    public GameObject 샷건설명;

    public GameObject 몽둥이설명;
    public GameObject 단검설명;
    public GameObject 도끼설명;

    public GameObject 화염병설명;


    public GameObject 소형권총탄약이미지;
    public GameObject 리볼버탄약이미지;
    public GameObject 소총탄약이미지;
    public GameObject 샷건탄약이미지;

    public GameObject 권총탄약설명;
    public GameObject 리볼버탄약설명;
    public GameObject 소총탄약설명;
    public GameObject 샷건탄약설명;

    public Text 권총탄약설명텍스트;
    public Text 리볼버탄약설명텍스트;
    public Text 소총탄약설명텍스트;
    public Text 샷건탄약설명텍스트;

    public Text 화염병설명텍스트;


    public Text 권총탄약보유수텍스트;
    public Text 리볼버탄약보유수텍스트;
    public Text 소총탄약보유수텍스트;
    public Text 샷건탄약보유수텍스트;

     public void 임시전투이동()
    {
        SceneManager.LoadScene("도로전투");
    }


    public void 인벤토리체커()
    {
        if(DataBaseManager.소형권총구매여부 == true)
        {
            권총탄약보유수텍스트.text = "보유 탄약 : " + DataBaseManager.보유권총탄약;
            소형권총이미지.SetActive(true);    
        }
        if (DataBaseManager.리볼버구매여부 == true)
        {
            리볼버탄약보유수텍스트.text = "보유 탄약 : " + DataBaseManager.보유리볼버탄약;
            리볼버이미지.SetActive(true);
        }
        if (DataBaseManager.소총구매여부 == true)
        {
            소총탄약보유수텍스트.text = "보유 탄약 : " + DataBaseManager.보유소총탄약;
            소총이미지.SetActive(true);
        }
        if (DataBaseManager.샷건구매여부 == true)
        {
            샷건탄약보유수텍스트.text = "보유 탄약 : " + DataBaseManager.보유샷건탄약;
            샷건이미지.SetActive(true);
        }
        //단검류
        if (DataBaseManager.몽둥이구매여부 == true)
        {

            몽둥이이미지.SetActive(true);
        }
        if (DataBaseManager.단검구매여부 == true)
        {

            단검이미지.SetActive(true);
        }
        if (DataBaseManager.도끼구매여부 == true)
        {

            도끼이미지.SetActive(true);
        }


        //탄약류
        if (DataBaseManager.보유권총탄약 > 0)
        {
            소형권총탄약이미지.SetActive(true);
            권총탄약설명텍스트.text = "소형권총에 사용하는 탄약. 현재 "+DataBaseManager.보유권총탄약 +"개 가지고 있다.";

        }
        if (DataBaseManager.보유권총탄약 <= 0)
        {
            소형권총탄약이미지.SetActive(false);
        }


        if (DataBaseManager.보유리볼버탄약 > 0)
        {
            리볼버탄약이미지.SetActive(true);
            리볼버탄약설명텍스트.text = "리볼버에에 사용하는 탄약. 현재 " + DataBaseManager.보유리볼버탄약 + "개 가지고 있다.";

        }
        if (DataBaseManager.보유리볼버탄약 <= 0)
        {
            리볼버탄약이미지.SetActive(false);
        }


        if (DataBaseManager.보유소총탄약 > 0)
        {
            소총탄약이미지.SetActive(true);
            소총탄약설명텍스트.text = "볼트액션 소총에 사용하는 탄약. 현재 " + DataBaseManager.보유소총탄약 + "개 가지고 있다.";

        }
        if (DataBaseManager.보유소총탄약 <= 0)
        {
            소총탄약이미지.SetActive(false);
        }


        if (DataBaseManager.보유샷건탄약 > 0)
        {
            샷건탄약이미지.SetActive(true);
            샷건탄약설명텍스트.text = "16게이지 샷건에 사용하는 탄약. 현재 " + DataBaseManager.보유샷건탄약 + "개 가지고 있다.";

        }
        if (DataBaseManager.보유샷건탄약 <= 0)
        {
            샷건탄약이미지.SetActive(false);
        }

        if (DataBaseManager.화염병보유수 > 0)
        {
            화염병이미지.SetActive(true);
            화염병설명텍스트.text = "개량된 화염병. 현재 " + DataBaseManager.화염병보유수 + "개 가지고 있다.";

        }
        if (DataBaseManager.화염병보유수 <= 0)
        {
            화염병이미지.SetActive(false);
        }
    }

    void 아이템설명초기회()
    {
        단검류배경칸.SetActive(false);
        무기류배경칸.SetActive(false);
        일반배경칸.SetActive(false);
        자동권총.SetActive(false);
        열쇠.SetActive(false);

        소형권총설명.SetActive(false);
        리볼버설명.SetActive(false);
        소총설명.SetActive(false);
        샷건설명.SetActive(false);
        
        권총탄약설명.SetActive(false);
        리볼버탄약설명.SetActive(false);
        샷건탄약설명.SetActive(false);
        소총탄약설명.SetActive(false);

        도끼설명.SetActive(false);
        단검설명.SetActive(false);
        몽둥이설명.SetActive(false);

        화염병설명.SetActive(false);
    }
    void 아이템설명업데이터()
    {
        if(itemMenuNum ==1)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum-1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" &&  리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 2)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 3)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 4)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 5)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 6)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 7)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 8)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 9)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 10)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 11)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 12)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 13)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 14)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
            }
        }
        if (itemMenuNum == 15)
        {
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "총" && 자동권총.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                자동권총.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "열쇠" && 열쇠.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                열쇠.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소형권총" && 소형권총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소형권총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버" && 리볼버이미지.activeSelf == true)

            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                리볼버설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총" && 소총이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                소총설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건" && 샷건이미지.activeSelf == true)
            {
                아이템설명초기회();
                무기류배경칸.SetActive(true);
                샷건설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "권총탄약" && 소형권총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                권총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "리볼버탄약" && 리볼버탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                리볼버탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "소총탄약" && 소총탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                소총탄약설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "샷건탄약" && 샷건탄약이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                샷건탄약설명.SetActive(true);
            }

            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "몽둥이" && 몽둥이이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                몽둥이설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "도끼" && 도끼이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                도끼설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "단검" && 단검이미지.activeSelf == true)
            {
                아이템설명초기회();
                단검류배경칸.SetActive(true);
                단검설명.SetActive(true);
            }
            if (인벤토리그리드.transform.GetChild(itemMenuNum - 1).name == "화염병" && 화염병이미지.activeSelf == true)
            {
                아이템설명초기회();
                일반배경칸.SetActive(true);
                화염병설명.SetActive(true);
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


    public void 마우스인벤토리정보창1()
    {
        itemMenuNum = 1;
    }
    public void 마우스인벤토리정보창2()
    {
        itemMenuNum = 2;
    }
    public void 마우스인벤토리정보창3()
    {
        itemMenuNum =3;
    }
    public void 마우스인벤토리정보창4()
    {
        itemMenuNum = 4;
    }
    public void 마우스인벤토리정보창5()
    {
        itemMenuNum = 5;
    }
    public void 마우스인벤토리정보창6()
    {
        itemMenuNum = 6;
    }
    public void 마우스인벤토리정보창7()
    {
        itemMenuNum = 7;
    }
    public void 마우스인벤토리정보창8()
    {
        itemMenuNum = 8;
    }
    public void 마우스인벤토리정보창9()
    {
        itemMenuNum = 9;
    }
    public void 마우스인벤토리정보창10()
    {
        itemMenuNum = 10;
    }
    public void 마우스인벤토리정보창11()
    {
        itemMenuNum = 11;
    }
    public void 마우스인벤토리정보창12()
    {
        itemMenuNum = 12;
    }
    public void 마우스인벤토리정보창13()
    {
        itemMenuNum = 13;
    }
    public void 마우스인벤토리정보창14()
    {
        itemMenuNum = 14;
    }
    public void 마우스인벤토리정보창15()
    {
        itemMenuNum = 15;
    }
    public void 마우스인벤토리정보창16()
    {
        itemMenuNum = 16;
    }
    public void 마우스인벤토리정보창17()
    {
        itemMenuNum = 17;
    }
    public void 마우스인벤토리정보창18()
    {
        itemMenuNum = 18;
    }
    public void 마우스인벤토리정보창19()
    {
        itemMenuNum = 19;
    }
    public void 마우스인벤토리정보창20()
    {
        itemMenuNum = 20;
    }


}
