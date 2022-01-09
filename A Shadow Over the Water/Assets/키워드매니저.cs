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
        if (DataBaseManager.대화창켜짐 == false  && DataBaseManager.연출진행중 == false)
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
        if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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

            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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

            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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

            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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

            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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

            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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

            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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






    public void 하위오른쪽이동()
    {


        if (DataBaseManager.키워드상위 == "불면증")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if (불면증키워드개수 <= 불면증키워드넘버)
                {
                    불면증키워드넘버 = 0;
                }
                else
                {
                    불면증키워드넘버 += 1;
                }
            }
        }
        if (DataBaseManager.키워드상위 == "악몽")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if (악몽키워드개수 <= 악몽키워드넘버)
                {
                    악몽키워드넘버 = 0;
                }
                else
                {
                    악몽키워드넘버 += 1;
                }
            }
        }
        if (DataBaseManager.키워드상위 == "편집증")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if (편집증키워드개수 <= 편집증키워드넘버)
                {
                    편집증키워드넘버 = 0;
                }
                else
                {
                    편집증키워드넘버 += 1;
                }
            }
        }

        if (DataBaseManager.키워드상위 == "에이든 트리스")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if (에이든키워드개수 <= 에이든키워드넘버)
                {
                    에이든키워드넘버 = 0;
                }
                else
                {
                    에이든키워드넘버 += 1;
                }
            }
        }
    }
    public void 하위왼쪽이동()
    {
        if (DataBaseManager.키워드상위 == "불면증")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if ( 불면증키워드넘버<=0)
                {
                    불면증키워드넘버 = 불면증키워드개수;
                }
                else
                {
                    불면증키워드넘버 -= 1;
                }   

            }
        }
        if (DataBaseManager.키워드상위 == "악몽")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if (악몽키워드넘버 <= 0)
                {
                    악몽키워드넘버 = 악몽키워드개수;
                }
                else
                {
                    악몽키워드넘버 -= 1;
                }

            }
        }
        if (DataBaseManager.키워드상위 == "편집증")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if (편집증키워드넘버 <= 0)
                {
                    편집증키워드넘버 = 편집증키워드개수;
                }
                else
                {
                    편집증키워드넘버 -= 1;
                }

            }
        }
        if (DataBaseManager.키워드상위 == "에이든 트리스")
        {
            if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
            {
                if (에이든키워드넘버 <= 0)
                {
                    에이든키워드넘버 = 에이든키워드개수;
                }
                else
                {
                    에이든키워드넘버 -= 1;
                }

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
    bool 편집증리스트추가여부 = false;
    bool 실종사건리스트추가여부 = false;
    bool 하수도괴담리스트추가여부 = false;
    bool 비릿한냄새리스트추가여부 = false;
    bool 강의수질추가여부 = false;
    bool 섬뜩한눈추가여부 = false;
    //장소
    bool 병원추가여부 = false;
    bool 의뢰자의집추가여부 = false;
    bool 신문사추가여부 = false;
    bool 강가추가여부 = false;
    //인물
    bool 에이든추가여부 = false;
    bool 엘라추가여부 = false;
    bool 스탠리추가여부 = false;
    bool 노교수추가여부 = false;




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
        if (편집증리스트추가여부 == false)
        {
            if (DataBaseManager.편집증정보1 == true || DataBaseManager.편집증정보2 == true || DataBaseManager.편집증정보3 == true || DataBaseManager.편집증정보4 == true || DataBaseManager.편집증정보5 == true || DataBaseManager.편집증정보6 == true)
            {
                편집증리스트추가여부 = true;
                상위사건키워드리스트.Add("편집증");
            }
        }
        if (실종사건리스트추가여부 == false)
        {
            if (DataBaseManager.실종된사람들정보1 == true || DataBaseManager.실종된사람들정보2 == true || DataBaseManager.실종된사람들정보3 == true || DataBaseManager.실종된사람들정보4 == true || DataBaseManager.실종된사람들정보5 == true || DataBaseManager.실종된사람들정보6 == true)
            {
                실종사건리스트추가여부 = true;
                상위사건키워드리스트.Add("실종 사건");
            }
        }
        if (하수도괴담리스트추가여부 == false)
        {
            if (DataBaseManager.하수도괴담정보1 == true || DataBaseManager.하수도괴담정보2 == true || DataBaseManager.하수도괴담정보3 == true || DataBaseManager.하수도괴담정보4 == true || DataBaseManager.하수도괴담정보5 == true || DataBaseManager.하수도괴담정보6 == true)
            {
                하수도괴담리스트추가여부 = true;
                상위사건키워드리스트.Add("하수도의 괴담");
            }
        }
        if (비릿한냄새리스트추가여부 == false)
        {
            if (DataBaseManager.비릿한냄새정보1 == true || DataBaseManager.비릿한냄새정보2 == true || DataBaseManager.비릿한냄새정보3 == true || DataBaseManager.비릿한냄새정보4 == true || DataBaseManager.비릿한냄새정보5 == true || DataBaseManager.비릿한냄새정보6 == true)
            {
                비릿한냄새리스트추가여부 = true;
                상위사건키워드리스트.Add("비릿한 냄새");
            }
        }
        if (강의수질추가여부 == false)
        {
            if (DataBaseManager.강의수질정보1 == true || DataBaseManager.강의수질정보2 == true || DataBaseManager.강의수질정보3 == true || DataBaseManager.강의수질정보4 == true || DataBaseManager.강의수질정보5 == true || DataBaseManager.강의수질정보6 == true)
            {
                강의수질추가여부 = true;
                상위사건키워드리스트.Add("미스캐토닉 강의 수질");
            }
        }
        if (섬뜩한눈추가여부 == false)
        {
            if (DataBaseManager.섬뜩한눈정보1 == true || DataBaseManager.섬뜩한눈정보2 == true || DataBaseManager.섬뜩한눈정보3 == true || DataBaseManager.섬뜩한눈정보4 == true || DataBaseManager.섬뜩한눈정보5 == true || DataBaseManager.섬뜩한눈정보6 == true)
            {
                섬뜩한눈추가여부 = true;
                상위사건키워드리스트.Add("하수도의 섬뜩한 눈");
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
        if (강가추가여부 == false)
        {
            if (DataBaseManager.강가정보1 == true || DataBaseManager.강가정보2 == true || DataBaseManager.강가정보3 == true || DataBaseManager.강가정보4 == true || DataBaseManager.강가정보5 == true || DataBaseManager.강가정보6 == true)
            {
                강가추가여부 = true;
                상위장소키워드리스트.Add("미스캐토닉 강");
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
        if (스탠리추가여부 == false)
        {
            if (DataBaseManager.동료기자정보1 == true || DataBaseManager.동료기자정보2 == true || DataBaseManager.동료기자정보3 == true || DataBaseManager.동료기자정보4 == true || DataBaseManager.동료기자정보5 == true || DataBaseManager.동료기자정보6 == true)
            {
                스탠리추가여부 = true;
                상위인물키워드리스트.Add("스탠리 큐브릭");
            }
        }
        if (노교수추가여부 == false)
        {
            if (DataBaseManager.노교수정보1 == true || DataBaseManager.노교수정보2 == true || DataBaseManager.노교수정보3 == true || DataBaseManager.노교수정보5 == true || DataBaseManager.노교수정보4 == true || DataBaseManager.노교수정보6 == true)
            {
                노교수추가여부 = true;
                상위인물키워드리스트.Add("노교수");
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
    int 불면증키워드개수;
    int 불면증키워드넘버 = 0;

    List<string> 편집증리스트 = new List<string>();//string들어가야하고
    int 편집증키워드개수;
    int 편집증키워드넘버 = 0;

    List<string> 실종사건리스트 = new List<string>();//string들어가야하고
    int 실종사건키워드개수 = 0;
    int 실종사건키워드넘버 = 0;

    List<string> 하수도괴담리스트 = new List<string>();//string들어가야하고
    int 하수도괴담키워드개수 = 0;
    int 하수도괴담키워드넘버 = 0;

    List<string> 비릿한냄새리스트 = new List<string>();//string들어가야하고
    int 비릿한냄새키워드개수 = 0;
    int 비릿한냄새키워드넘버 = 0;

    List<string> 강의수질리스트 = new List<string>();//string들어가야하고
    int 강의수질키워드개수 = 0;
    int 강의수질키워드넘버 = 0;

    List<string> 섬뜩한눈리스트 = new List<string>();//string들어가야하고
    int 섬뜩한눈키워드개수 = 0;
    int 섬뜩한눈키워드넘버 = 0;
    //사건
    bool 행성대직렬정보1추가여부 = false;
    bool 악몽정보1추가여부 = false;
    bool 악몽정보2추가여부 = false;
    bool 불면증정보1추가여부 = false;
    bool 불면증정보2추가여부 = false;
    bool 불면증정보3추가여부 = false;
    bool 편집증정보1추가여부 = false;
    bool 편집증정보2추가여부 = false;
    bool 실종사건정보1추가여부 = false;
    bool 실종사건정보2추가여부 = false;
    bool 하수도괴담정보1추가여부 = false;
    bool 비릿한냄새정보1추가여부 = false;
    bool 강의수질정보1추가여부 = false;
    bool 섬뜩한눈정보1추가여부 = false;
    // ------------------------------- 인물하위
    List<string> 에이든리스트 = new List<string>();//string들어가야하고
    int 에이든키워드개수 = 0;
    int 에이든키워드넘버 = 0;

    List<string> 엘라리스트 = new List<string>();//string들어가야하고
    int 엘라키워드개수 = 0;
    int 엘라키워드넘버 = 0;
    List<string> 스탠리리스트 = new List<string>();//string들어가야하고
    int 스탠리키워드개수 = 0;
    int 스탠리키워드넘버 = 0;
    List<string> 노교수리스트 = new List<string>();//string들어가야하고
    int 노교수키워드개수 = 0;
    int 노교수키워드넘버 = 0;
    //사건
    bool 에이든정보1추가여부 = false;
    bool 에이든정보2추가여부 = false;
    bool 에이든정보3추가여부 = false;
    bool 엘라정보1추가여부 = false;
    bool 스탠리정보1추가여부 = false;
    bool 노교수정보1추가여부 = false;
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

    List<string> 강가리스트 = new List<string>();//string들어가야하고
    int 강가키워드개수 = 0;
    int 강가키워드넘버 = 0;
    //사건
    bool 병원정보1추가여부 = false;
    bool 신문사정보1추가여부 = false;
    bool 의뢰자의집정보1추가여부 = false;
    bool 강가정보1추가여부 = false;
    public void 하위키워드업데이터()
    {        

        행성대직렬키워드개수 = 행성대직렬리스트.Count-1;
        악몽키워드개수 = 악몽리스트.Count - 1;
        불면증키워드개수 = 불면증리스트.Count - 1;
        편집증키워드개수 = 편집증리스트.Count - 1;
        실종사건키워드개수 = 실종사건리스트.Count - 1;
        하수도괴담키워드개수 = 하수도괴담리스트.Count - 1;
        비릿한냄새키워드개수 = 비릿한냄새리스트.Count - 1;
        강의수질키워드개수 = 강의수질리스트.Count - 1;
        섬뜩한눈키워드개수 = 섬뜩한눈리스트.Count - 1;

        엘라키워드개수 = 엘라리스트.Count - 1;
        에이든키워드개수 = 에이든리스트.Count - 1;
        스탠리키워드개수 = 스탠리리스트.Count - 1;
        노교수키워드개수 = 노교수리스트.Count - 1;

        병원키워드개수 = 병원리스트.Count - 1;
        의뢰자의집키워드개수 = 의뢰자의집리스트.Count - 1;
        신문사키워드개수 = 신문사리스트.Count - 1;
        강가키워드개수 = 강가리스트.Count - 1;


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

        if (DataBaseManager.악몽정보2 == true && 악몽정보2추가여부 == false)
        {
            악몽정보2추가여부 = true;
            악몽리스트.Add("악몽의 내용");
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
        if (DataBaseManager.불면증정보2 == true && 불면증정보2추가여부 == false)
        {
            불면증정보2추가여부 = true;
            불면증리스트.Add("병원의 불면증 환자");
        }
        if (DataBaseManager.불면증정보3 == true && 불면증정보3추가여부 == false)
        {
            불면증정보3추가여부 = true;
            불면증리스트.Add("불면증의 원인");
        }
        // 편집증
        else if (DataBaseManager.키워드상위 == "편집증" && 편집증키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 편집증리스트[편집증키워드넘버];
        }

        if (DataBaseManager.편집증정보1 == true && 편집증정보1추가여부 == false)
        {
            편집증정보1추가여부 = true;
            편집증리스트.Add("편집증 유행");
        }
        if (DataBaseManager.편집증정보2 == true && 편집증정보2추가여부 == false)
        {
            편집증정보2추가여부 = true;
            편집증리스트.Add("편집증의 원인");
        }
        // 실종사건
        else if (DataBaseManager.키워드상위 == "실종 사건" && 실종사건키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 실종사건리스트[실종사건키워드넘버];
        }

        if (DataBaseManager.실종된사람들정보1 == true && 실종사건정보1추가여부 == false)
        {
            실종사건정보1추가여부 = true;
            실종사건리스트.Add("연속 실종 사건");
        }

        if (DataBaseManager.실종된사람들정보2 == true && 실종사건정보2추가여부 == false)
        {
            실종사건정보2추가여부 = true;
            실종사건리스트.Add("취재 - 연속 실종");
        }


        // 하수도괴담.
        else if (DataBaseManager.키워드상위 == "하수도의 괴담" && 하수도괴담키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 하수도괴담리스트[하수도괴담키워드넘버];
        }

        if (DataBaseManager.하수도괴담정보1 == true && 하수도괴담정보1추가여부 == false)
        {
            하수도괴담정보1추가여부 = true;
            하수도괴담리스트.Add("에이든이 취재하던 것");
        }

        // 비릿한냄새
        else if (DataBaseManager.키워드상위 == "비릿한 냄새" && 비릿한냄새키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 비릿한냄새리스트[비릿한냄새키워드넘버];
        }

        if (DataBaseManager.비릿한냄새정보1 == true && 비릿한냄새정보1추가여부 == false)
        {
            비릿한냄새정보1추가여부 = true;
            비릿한냄새리스트.Add("비릿한 냄새 소문");
        }

        // 강의수질
        else if (DataBaseManager.키워드상위 == "미스캐토닉 강의 수질" && 강의수질키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 강의수질리스트[강의수질키워드넘버];
        }

        if (DataBaseManager.강의수질정보1 == true && 강의수질정보1추가여부 == false)
        {
            강의수질정보1추가여부 = true;
            강의수질리스트.Add("강의 특이점");
        }

        // 섬뜩한눈
        else if (DataBaseManager.키워드상위 == "하수도의 섬뜩한 눈" && 섬뜩한눈키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 섬뜩한눈리스트[섬뜩한눈키워드넘버];
        }

        if (DataBaseManager.섬뜩한눈정보1 == true && 섬뜩한눈정보1추가여부 == false)
        {
            섬뜩한눈정보1추가여부 = true;
            섬뜩한눈리스트.Add("하수도의 섬뜩한 눈");
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
        if (DataBaseManager.에이든정보2 == true && 에이든정보2추가여부 == false)
        {
            에이든정보2추가여부 = true;
            에이든리스트.Add("에이든의 상태");
        }
        if (DataBaseManager.에이든정보3 == true && 에이든정보3추가여부 == false)
        {
            에이든정보3추가여부 = true;
            에이든리스트.Add("에이든의 발언");
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

        // 스탠리
        if (DataBaseManager.키워드상위 == "스탠리 큐브릭" && 스탠리키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 스탠리리스트[스탠리키워드넘버];
        }
        if (DataBaseManager.동료기자정보1 == true && 스탠리정보1추가여부 == false)
        {
            스탠리정보1추가여부 = true;
            스탠리리스트.Add("스탠리 큐브릭");
        }

        // 노교수
        if (DataBaseManager.키워드상위 == "노교수" && 노교수키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 노교수리스트[노교수키워드넘버];
        }
        if (DataBaseManager.노교수정보1 == true && 노교수정보1추가여부 == false)
        {
            노교수정보1추가여부 = true;
            노교수리스트.Add("신이난 노교수");
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

        // 강가
        if (DataBaseManager.키워드상위 == "미스캐토닉 강" && 강가키워드개수 >= 0)
        {
            DataBaseManager.키워드하위 = 강가리스트[강가키워드넘버];
        }
        if (DataBaseManager.강가정보1 == true && 강가정보1추가여부 == false)
        {
            강가정보1추가여부 = true;
            강가리스트.Add("강과 교수");
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
