using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 키워드매니저 : MonoBehaviour
{
    public Text 주제설정;
    public Text 상위설정;
    public Text 하위설정;
    public GameObject 대화창활성화여부;
    public void 주제오른쪽이동()
    {
        if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
        {
            if (DataBaseManager.키워드주제 == "사건")
            {
                DataBaseManager.키워드주제 = "인물";
                DataBaseManager.키워드상위 = 상위인물키워드리스트[현재인물상위키워드넘버];
            }
            else if (DataBaseManager.키워드주제 == "인물")
            {
                DataBaseManager.키워드주제 = "장소";
                DataBaseManager.키워드상위 = 상위장소키워드리스트[현재장소상위키워드넘버];
            }
            else if (DataBaseManager.키워드주제 == "장소")
            {
                DataBaseManager.키워드주제 = "사건";
                DataBaseManager.키워드상위 = 상위사건키워드리스트[현재사건상위키워드넘버];
            }
        }

    }
    public void 주제왼쪽이동()
    {
        if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
        {
            if (DataBaseManager.키워드주제 == "사건")
            {
                DataBaseManager.키워드주제 = "장소";
                DataBaseManager.키워드상위 = 상위장소키워드리스트[현재장소상위키워드넘버];
            }
            else if (DataBaseManager.키워드주제 == "인물")
            {
                DataBaseManager.키워드주제 = "사건";
                DataBaseManager.키워드상위 = 상위사건키워드리스트[현재사건상위키워드넘버];
            }
            else if (DataBaseManager.키워드주제 == "장소")
            {
                DataBaseManager.키워드주제 = "인물";
                DataBaseManager.키워드상위 = 상위인물키워드리스트[현재인물상위키워드넘버];
            }

        }

    }

    public void 상위오른쪽이동()
    {

        if (DataBaseManager.키워드주제 == "사건")
        {

            if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
            {
                현재사건상위키워드넘버 += 1;
                if (상위사건키워드개수 < 현재사건상위키워드넘버)
                {
                    현재사건상위키워드넘버 = 0;
                }


                DataBaseManager.키워드상위 = 상위사건키워드리스트[현재사건상위키워드넘버];

            }

        }

        else if (DataBaseManager.키워드주제 == "장소")
        {

            if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
            {
                현재장소상위키워드넘버 += 1;
                if (상위장소키워드개수 < 현재장소상위키워드넘버)
                {
                    현재장소상위키워드넘버 = 0;
                }


                DataBaseManager.키워드상위 = 상위장소키워드리스트[현재장소상위키워드넘버];

            }

        }
        else if (DataBaseManager.키워드주제 == "인물")
        {

            if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
            {
                현재인물상위키워드넘버 += 1;
                if (상위인물키워드개수 < 현재인물상위키워드넘버)
                {
                    현재인물상위키워드넘버 = 0;
                }


                DataBaseManager.키워드상위 = 상위인물키워드리스트[현재인물상위키워드넘버];

            }

        }
    }
    public void 상위왼쪽이동()
    {
        if (DataBaseManager.키워드주제 == "사건")
        {

            if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
            {
                현재사건상위키워드넘버 -= 1;
                if (0 > 현재사건상위키워드넘버)
                {
                    현재사건상위키워드넘버 = 상위사건키워드개수;
                }


                DataBaseManager.키워드상위 = 상위사건키워드리스트[현재사건상위키워드넘버];

            }


        }
        else if (DataBaseManager.키워드주제 == "장소")
        {

            if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
            {
                현재장소상위키워드넘버 -= 1;
                if (0 > 현재장소상위키워드넘버)
                {
                    현재장소상위키워드넘버 = 상위장소키워드개수;
                }


                DataBaseManager.키워드상위 = 상위장소키워드리스트[현재장소상위키워드넘버];

            }


        }
        else if (DataBaseManager.키워드주제 == "인물")
        {

            if (대화창활성화여부.activeSelf == false && DataBaseManager.연출진행중 == false)
            {
                현재인물상위키워드넘버 -= 1;
                if (0 > 현재인물상위키워드넘버)
                {
                    현재인물상위키워드넘버 = 상위인물키워드개수;
                }


                DataBaseManager.키워드상위 = 상위인물키워드리스트[현재인물상위키워드넘버];

            }


        }
    }
    List<string> 상위사건키워드리스트 = new List<string>();//string들어가야하고
     int 상위사건키워드개수 = 0;
     int 현재사건상위키워드넘버 = 0;

    List<string> 상위인물키워드리스트 = new List<string>();//string들어가야하고
     int 상위인물키워드개수 = 0;
     int 현재인물상위키워드넘버 = 0;

    List<string> 상위장소키워드리스트 = new List<string>();//string들어가야하고
     int 상위장소키워드개수 = 0;
     int 현재장소상위키워드넘버 = 0;

    //사건
    bool 행성대직렬리스트추가여부 = false;
    bool 악몽리스트추가여부 = false;
    bool 불면증리스트추가여부 = false;
    //장소
    bool 병원추가여부 = false;
    bool 의뢰자의집추가여부 = false;
    bool 신문사추가여부 = false;
    //인물
    bool 에이든추가여부 = false;
    bool 엘라추가여부 = false;





    public void 키워드업데이터()
    {


        주제설정.text = "< " + DataBaseManager.키워드주제 + " >";
        상위설정.text = "< " + DataBaseManager.키워드상위 + " >";
        하위설정.text = "< " + DataBaseManager.키워드하위 + " >";

        // 상위키워드 업데이트

        상위사건키워드개수 = 상위사건키워드리스트.Count-1;
        상위인물키워드개수 = 상위인물키워드리스트.Count - 1;
        상위장소키워드개수 = 상위장소키워드리스트.Count - 1;



        // 사건
        if (행성대직렬리스트추가여부 == false)
        {
            if (DataBaseManager.행성대직렬정보1 == true || DataBaseManager.행성대직렬정보2 == true || DataBaseManager.행성대직렬정보3 == true || DataBaseManager.행성대직렬정보4 == true || DataBaseManager.행성대직렬정보5 == true || DataBaseManager.행성대직렬정보6 == true)
            {
                행성대직렬리스트추가여부 = true;
                상위사건키워드리스트.Add("행성대직렬");
            }
        }
        if(악몽리스트추가여부 == false)
        {
            if (DataBaseManager.악몽정보1 == true || DataBaseManager.악몽정보2 == true || DataBaseManager.악몽정보3 == true || DataBaseManager.악몽정보4 == true || DataBaseManager.악몽정보5 == true || DataBaseManager.악몽정보6 == true)
            {
                악몽리스트추가여부 = true;
                상위사건키워드리스트.Add("악몽");
            }
        }
        if (불면증리스트추가여부 == false)
        {
            if (DataBaseManager.불면증정보1 == true || DataBaseManager.불면증정보2 == true || DataBaseManager.불면증정보3 == true || DataBaseManager.불면증정보4 == true || DataBaseManager.불면증정보5 == true || DataBaseManager.불면증정보6 == true)
            {
                불면증리스트추가여부 = true;
                상위사건키워드리스트.Add("불면증");
            }
        }


        //장소
        if (병원추가여부 == false)
        {
            if (DataBaseManager.병원정보1 == true || DataBaseManager.병원정보2 == true || DataBaseManager.병원정보3 == true || DataBaseManager.병원정보4 == true || DataBaseManager.병원정보5 == true || DataBaseManager.병원정보6 == true)
            {
                병원추가여부 = true;
                상위장소키워드리스트.Add("병원");
            }
        }
        if (의뢰자의집추가여부 == false)
        {
            if (DataBaseManager.의뢰자의집정보1 == true || DataBaseManager.의뢰자의집정보2 == true || DataBaseManager.의뢰자의집정보3 == true || DataBaseManager.의뢰자의집정보4 == true || DataBaseManager.의뢰자의집정보5 == true || DataBaseManager.의뢰자의집정보6 == true)
            {
                의뢰자의집추가여부 = true;
                상위장소키워드리스트.Add("의뢰자의 집");
            }
        }
        if (신문사추가여부 == false)
        {
            if (DataBaseManager.신문사정보1 == true || DataBaseManager.신문사정보2 == true || DataBaseManager.신문사정보3 == true || DataBaseManager.신문사정보4 == true || DataBaseManager.신문사정보5 == true || DataBaseManager.신문사정보6 == true)
            {
                신문사추가여부 = true;
                상위장소키워드리스트.Add("데일리뉴스 신문사");
            }
        }





        //인물
        if (에이든추가여부 == false)
        {
            if (DataBaseManager.에이든정보1 == true || DataBaseManager.에이든정보2 == true || DataBaseManager.에이든정보3 == true || DataBaseManager.에이든정보4 == true || DataBaseManager.에이든정보5 == true || DataBaseManager.에이든정보6 == true)
            {
                에이든추가여부 = true;
                상위인물키워드리스트.Add("에이든 트리스");
            }
        }

        if (엘라추가여부 == false)
        {
            if (DataBaseManager.엘라정보1 == true || DataBaseManager.엘라정보2 == true || DataBaseManager.엘라정보3 == true || DataBaseManager.엘라정보4 == true || DataBaseManager.엘라정보5 == true || DataBaseManager.엘라정보6 == true)
            {
                엘라추가여부 = true;
                상위인물키워드리스트.Add("엘라 트리스");
            }
        }





    }
    // ------------------------------- 사건하위
    List<string> 행성대직렬리스트 = new List<string>();//string들어가야하고
    int 행성대직렬키워드개수 = 0;
    int 행성대직렬키워드넘버 = 0;

    List<string> 악몽리스트 = new List<string>();//string들어가야하고
    int 악몽키워드개수 = 0;
    int 악몽키워드넘버 = 0;

    List<string> 불면증리스트 = new List<string>();//string들어가야하고
    int 불면증키워드개수 = 0;
    int 불면증키워드넘버 = 0;

    //사건
    bool 행성대직렬정보1추가여부 = false;
    bool 악몽정보1추가여부 = false;
    bool 불면증정보1추가여부 = false;

    // ------------------------------- 인물하위
    List<string> 에이든리스트 = new List<string>();//string들어가야하고
    int 에이든키워드개수 = 0;
    int 에이든키워드넘버 = 0;

    List<string> 엘라리스트 = new List<string>();//string들어가야하고
    int 엘라키워드개수 = 0;
    int 엘라키워드넘버 = 0;

    //사건
    bool 에이든정보1추가여부 = false;
    bool 엘라정보1추가여부 = false;


    // ------------------------------- 장소하위
    List<string> 병원리스트 = new List<string>();//string들어가야하고
    int 병원키워드개수 = 0;
    int 병원키워드넘버 = 0;

    List<string> 신문사리스트 = new List<string>();//string들어가야하고
    int 신문사키워드개수 = 0;
    int 신문사키워드넘버 = 0;

    List<string> 의뢰자의집리스트 = new List<string>();//string들어가야하고
    int 의뢰자의집키워드개수 = 0;
    int 의뢰자의집키워드넘버 = 0;
    //사건
    bool 병원정보1추가여부 = false;
    bool 신문사정보1추가여부 = false;
    bool 의뢰자의집정보1추가여부 = false;
    public void 하위키워드업데이터()
    {        

        행성대직렬키워드개수 = 행성대직렬리스트.Count-1;
        악몽키워드개수 = 악몽리스트.Count - 1;
        불면증키워드개수 = 불면증리스트.Count - 1;

        엘라키워드개수 = 엘라리스트.Count - 1;
        에이든키워드개수 = 에이든리스트.Count - 1;

        병원키워드개수 = 병원리스트.Count - 1;
        의뢰자의집키워드개수 = 의뢰자의집리스트.Count - 1;
        신문사키워드개수 = 신문사리스트.Count - 1;

      
        // 사건 

        // 행성대직렬
        if (DataBaseManager.키워드상위 == "행성대직렬"&& 행성대직렬키워드개수>=0)
        {
            DataBaseManager.키워드하위 = 행성대직렬리스트[행성대직렬키워드넘버];
        }
 
        if (DataBaseManager.행성대직렬정보1 == true&&행성대직렬정보1추가여부 == false)
        {
            행성대직렬정보1추가여부 = true;
            행성대직렬리스트.Add("행성대직렬 신문기사");
        }


        // 악몽
        else if (DataBaseManager.키워드상위 == "악몽" && 악몽키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 악몽리스트[악몽키워드넘버];
        }

        if (DataBaseManager.악몽정보1 == true && 악몽정보1추가여부 == false)
        {
            악몽정보1추가여부 = true;
            악몽리스트.Add("에이든의 악몽");
        }

        // 불면증
        else if (DataBaseManager.키워드상위 == "불면증" && 불면증키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 불면증리스트[불면증키워드넘버];
        }

        if (DataBaseManager.불면증정보1 == true && 불면증정보1추가여부 == false)
        {
            불면증정보1추가여부 = true;
            불면증리스트.Add("불면증 유행");
        }



        // 인물

        // 에이든
        if (DataBaseManager.키워드상위 == "에이든 트리스" && 에이든키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 에이든리스트[에이든키워드넘버];
        }
        if (DataBaseManager.에이든정보1 == true && 에이든정보1추가여부 == false)
        {
            에이든정보1추가여부 = true;
            에이든리스트.Add("에이든 트리스");
        }


        // 엘라
        if (DataBaseManager.키워드상위 == "엘라 트리스" && 엘라키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 엘라리스트[엘라키워드넘버];
        }
        if (DataBaseManager.엘라정보1 == true && 엘라정보1추가여부 == false)
        {
            엘라정보1추가여부 = true;
            엘라리스트.Add("엘라 트리스");
        }




        // 장소 

        // 병원
        if (DataBaseManager.키워드상위 == "병원" && 병원키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 병원리스트[병원키워드넘버];
        }
        if (DataBaseManager.병원정보1 == true && 병원정보1추가여부 == false)
        {
            병원정보1추가여부 = true;
            병원리스트.Add("병원과 의뢰자");
        }



        // 신문사
        if (DataBaseManager.키워드상위 == "데일리뉴스 신문사" && 신문사키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 신문사리스트[신문사키워드넘버];
        }
        if (DataBaseManager.신문사정보1 == true && 신문사정보1추가여부 == false)
        {
            신문사정보1추가여부 = true;
            신문사리스트.Add("남편의 직장");
        }



        // 의뢰자의 집
        if (DataBaseManager.키워드상위 == "의뢰자의 집" && 의뢰자의집키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 의뢰자의집리스트[의뢰자의집키워드넘버];
        }
        if (DataBaseManager.의뢰자의집정보1 == true && 의뢰자의집정보1추가여부 == false)
        {
            의뢰자의집정보1추가여부 = true;
            의뢰자의집리스트.Add("의뢰자의 집");
        }
   


    }

    // Start is called before the first frame update
    void Start()
    {

        if (DataBaseManager.키워드주제 == "")
        {
            DataBaseManager.키워드주제 = "사건";
        }
        if (DataBaseManager.키워드상위 == "")
        {
            DataBaseManager.키워드상위 = "행성대직렬";
        }
        if (DataBaseManager.키워드하위 == "")
        {
            DataBaseManager.키워드하위 = "--- ---";
        }

    }

    // Update is called once per frame
    void Update()
    {
        하위키워드업데이터();
        키워드업데이터();
    }


  
}
