using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class settingManager : MonoBehaviour
{
    public GameObject 대화창1;
    public GameObject 대화창2;
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
        if (DataBaseManager.대화창켜짐 == false && DataBaseManager.연출진행중 == false)
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

    public bool 대화창켜야하나 = false;
    public void 옵션창켜기()
    {
        if (대화창1.activeSelf == true)
        {
            대화창켜야하나 = true;
        }
        else if (대화창1.activeSelf == false)
        {
            대화창켜야하나 = false;
        }
        대화창1.SetActive(false);
        대화창2.SetActive(false);


        if (DataBaseManager.옵션창여부 == false)
        {
            DataBaseManager.옵션창여부 = true;
            Time.timeScale = 0;
            옵션창.SetActive(true);

        }




    }
    public void 처음으로버튼()
    {
        //설정창끄기();
        Time.timeScale = 1;
        DataBaseManager.키워드주제 = "";
        DataBaseManager.키워드상위 = "";
        DataBaseManager.키워드하위 = "";

        DataBaseManager.하수도관찰력판정여부 = false;
        DataBaseManager.노교수관찰력판정여부 = false;

        DataBaseManager.대학생관찰력판정여부 = false;

        DataBaseManager.스탠리언변술판정여부 = false;
        DataBaseManager.스탠리심리학판정여부 = false;
        DataBaseManager.스탠리언변술성공여부 = false;


        DataBaseManager.에이든의학판정여부 = false;
        DataBaseManager.에이든정신분석판정여부 = false;
        DataBaseManager.에이든1일차최초대화완료여부 = false;

        DataBaseManager.최초의뢰인집 = false;

        DataBaseManager.대화중기능판정 = false;
        DataBaseManager.연출진행중 = false;
        //정보 알리미 관련 
        DataBaseManager.정보창알리미 = false;
        DataBaseManager.사건창알리미 = false;
        DataBaseManager.인물창알리미 = false;
        DataBaseManager.장소창알리미 = false;

        DataBaseManager.노아알리미 = false;
        DataBaseManager.멜리사알리미 = false;
        DataBaseManager.엘라알리미 = false;
        DataBaseManager.악몽알리미 = false;
        DataBaseManager.행성대직렬알리미 = false;
        DataBaseManager.편집증알리미 = false;
        DataBaseManager.불면증알리미 = false;
        DataBaseManager.실종사건알리미 = false;
        DataBaseManager.탐정사무소알리미 = false;
        DataBaseManager.병원알리미 = false;
        DataBaseManager.신문사알리미 = false;
        DataBaseManager.의뢰자의집알리미 = false;
        DataBaseManager.아캄역알리미 = false;


        DataBaseManager.옵션창여부 = false;
        DataBaseManager.판정창여부 = false;
        //기능판정관련.(사물,기물,인물반응)

        //탐정사무소기능반응
        DataBaseManager.신문기능판정여부 = false;


        //총알
        DataBaseManager.보유리볼버탄약 = 0;
        DataBaseManager.보유소총탄약 = 0;
        DataBaseManager.보유권총탄약 = 0;
        DataBaseManager.보유샷건탄약 = 0;
        DataBaseManager.화염병보유수 = 0;


        DataBaseManager.리볼버장탄수 = 0;
        DataBaseManager.소총장탄수 = 0;
        DataBaseManager.샷건장탄수 = 0;
        DataBaseManager.소형권총장탄수 = 0;

        //상점구매관련, 재력관련 파트
        DataBaseManager.재력 = 0;
        DataBaseManager.리볼버구매여부 = false;
        DataBaseManager.소형권총구매여부 = false;
        DataBaseManager.샷건구매여부 = false;
        DataBaseManager.소총구매여부 = false;

        DataBaseManager.몽둥이구매여부 = false;
        DataBaseManager.단검구매여부 = false;
        DataBaseManager.도끼구매여부 = false;



        //
        DataBaseManager.연출중움직임제한 = false;


        DataBaseManager.장면이동중 = false;
        DataBaseManager.카메라워킹온오프 = false;
        DataBaseManager.카메라왼쪽워킹온오프 = false;
        DataBaseManager.아침사무소연출 = false;
        DataBaseManager.스킵활성화 = false;
        DataBaseManager.시간대 = 1;
        DataBaseManager.이동지 = "";

        DataBaseManager.음악소리크기 = 0.5f;
        DataBaseManager.이펙트소리크기 = 0.5f;


        // Start is called before the first frame update
        DataBaseManager.힘 = 0;
        DataBaseManager.지능 = 0;
        DataBaseManager.민첩 = 0;
        DataBaseManager.행운 = 0;

        DataBaseManager.활력 = 0;
        DataBaseManager.마력 = 0;
        DataBaseManager.의지력 = 0;

        DataBaseManager.체력 = 0;
        DataBaseManager.정신력 = 0;
        DataBaseManager.현재체력 = 0;
        DataBaseManager.현재정신력 = 0;
        DataBaseManager.스트레스게이지 = 0;



        //힘 기반
        DataBaseManager.맨손격투 = 0;
        DataBaseManager.사격술 = 0;
        DataBaseManager.검술 = 0;
        DataBaseManager.고문술 = 0;
        DataBaseManager.눈썰미 = 0;
        DataBaseManager.언변술_협박 = 0;
        DataBaseManager.던지기 = 0;
        DataBaseManager.잠수 = 0;
        //지능 기반
        DataBaseManager.의학지식 = 0;
        DataBaseManager.정보조사 = 0;
        DataBaseManager.심리판단 = 0;
        DataBaseManager.오컬트지식 = 0;
        DataBaseManager.정신감정 = 0;
        DataBaseManager.언변술_설득 = 0;
        DataBaseManager.붕대감기 = 0;
        DataBaseManager.법의학 = 0;
        //민첩 기반
        DataBaseManager.구르기 = 0;
        DataBaseManager.변장술 = 0;
        DataBaseManager.언변술 = 0;
        DataBaseManager.자물쇠따기 = 0;
        DataBaseManager.손재주 = 0;
        DataBaseManager.은신 = 0;
        DataBaseManager.연기술 = 0;
        DataBaseManager.운동신경 = 0;


        DataBaseManager.대화창켜짐 = false;



        DataBaseManager.메뉴창켜짐 = false;

        //1일차 오전 사무소 확인여부
        DataBaseManager._1일차오전심리학판정성공여부 = false;
        DataBaseManager.선택1_3가만히있기를했는가 = false;


        //획득정보 확인.

        //인물정보

        DataBaseManager.노아현재페이지 = 1;
        DataBaseManager.멜리사현재페이지 = 1;
        DataBaseManager.엘라현재페이지 = 1;
        DataBaseManager.에이든현재페이지 = 1;
        DataBaseManager.노교수현재페이지 = 1;
        DataBaseManager.하수정비사무소장현재페이지 = 1;
        DataBaseManager.경찰친구현재페이지 = 1;
        DataBaseManager.술집친구현재페이지 = 1;
        DataBaseManager.동료기자현재페이지 = 1;
        DataBaseManager.현재획득한인물정보가지수 = 0;

        DataBaseManager.노아버튼순서 = -1;
        DataBaseManager.멜리사버튼순서 = -1;
        DataBaseManager.엘라버튼순서 = -1;
        DataBaseManager.에이든버튼순서 = -1;
        DataBaseManager.노교수버튼순서 = -1;
        DataBaseManager.경찰친구버튼순서 = -1;
        DataBaseManager.술집친구버튼순서 = -1;
        DataBaseManager.하수정비사무소소장버튼순서 = -1;
        DataBaseManager.동료기자버튼순서 = -1;


        DataBaseManager.노아정보1 = false;
        DataBaseManager.노아정보2 = false;
        DataBaseManager.노아정보3 = false;
        DataBaseManager.노아정보4 = false;
        DataBaseManager.노아정보5 = false;
        DataBaseManager.노아정보6 = false;

        DataBaseManager.멜리사정보1 = false;
        DataBaseManager.멜리사정보2 = false;
        DataBaseManager.멜리사정보3 = false;
        DataBaseManager.멜리사정보4 = false;
        DataBaseManager.멜리사정보5 = false;
        DataBaseManager.멜리사정보6 = false;

        DataBaseManager.에이든정보1 = false;
        DataBaseManager.에이든정보2 = false;
        DataBaseManager.에이든정보3 = false;
        DataBaseManager.에이든정보4 = false;
        DataBaseManager.에이든정보5 = false;
        DataBaseManager.에이든정보6 = false;

        DataBaseManager.엘라정보1 = false;
        DataBaseManager.엘라정보2 = false;
        DataBaseManager.엘라정보3 = false;
        DataBaseManager.엘라정보4 = false;
        DataBaseManager.엘라정보5 = false;
        DataBaseManager.엘라정보6 = false;

        DataBaseManager.동료기자정보1 = false;
        DataBaseManager.동료기자정보2 = false;
        DataBaseManager.동료기자정보3 = false;
        DataBaseManager.동료기자정보4 = false;
        DataBaseManager.동료기자정보5 = false;
        DataBaseManager.동료기자정보6 = false;

        DataBaseManager.노교수정보1 = false;
        DataBaseManager.노교수정보2 = false;
        DataBaseManager.노교수정보3 = false;
        DataBaseManager.노교수정보4 = false;
        DataBaseManager.노교수정보5 = false;
        DataBaseManager.노교수정보6 = false;
        DataBaseManager.경찰친구정보1 = false;
        DataBaseManager.경찰친구정보2 = false;
        DataBaseManager.경찰친구정보3 = false;
        DataBaseManager.경찰친구정보4 = false;
        DataBaseManager.경찰친구정보5 = false;
        DataBaseManager.경찰친구정보6 = false;

        DataBaseManager.술집친구정보1 = false;
        DataBaseManager.술집친구정보2 = false;
        DataBaseManager.술집친구정보3 = false;
        DataBaseManager.술집친구정보4 = false;
        DataBaseManager.술집친구정보5 = false;
        DataBaseManager.술집친구정보6 = false;

        DataBaseManager.하수정비사무소소장정보1 = false;
        DataBaseManager.하수정비사무소소장정보2 = false;
        DataBaseManager.하수정비사무소소장정보3 = false;
        DataBaseManager.하수정비사무소소장정보4 = false;
        DataBaseManager.하수정비사무소소장정보5 = false;
        DataBaseManager.하수정비사무소소장정보6 = false;



        //사건정보

        DataBaseManager.행성대직렬현재페이지 = 1;
        DataBaseManager.악몽현재페이지 = 1;
        DataBaseManager.편집증현재페이지 = 1;
        DataBaseManager.불면증현재페이지 = 1;
        DataBaseManager.하수도괴담현재페이지 = 1;
        DataBaseManager.실종된사람들현재페이지 = 1;
        DataBaseManager.비릿한냄새현재페이지 = 1;
        DataBaseManager.강의수질현재페이지 = 1;
        DataBaseManager.섬뜩한눈현재페이지 = 1;
        DataBaseManager.하수도노동자현재페이지 = 1;
        DataBaseManager.급격한교체현재페이지 = 1;

        DataBaseManager.현재획득한사건정보가지수 = 0;

        DataBaseManager.행성대직렬버튼순서 = -1;
        DataBaseManager.악몽버튼순서 = -1;
        DataBaseManager.편집증버튼순서 = -1;
        DataBaseManager.불면증버튼순서 = -1;
        DataBaseManager.하수도괴담버튼순서 = -1;
        DataBaseManager.실종된사람들버튼순서 = -1;
        DataBaseManager.비릿한냄새버튼순서 = -1;
        DataBaseManager.강의수질버튼순서 = -1;
        DataBaseManager.섬뜩한눈버튼순서 = -1;
        DataBaseManager.하수도노동자버튼순서 = -1;
        DataBaseManager.급격한교체버튼순서 = -1;







        DataBaseManager.악몽정보1 = false;
        DataBaseManager.악몽정보2 = false;
        DataBaseManager.악몽정보3 = false;
        DataBaseManager.악몽정보4 = false;
        DataBaseManager.악몽정보5 = false;
        DataBaseManager.악몽정보6 = false;

        DataBaseManager.행성대직렬정보1 = false;
        DataBaseManager.행성대직렬정보2 = false;
        DataBaseManager.행성대직렬정보3 = false;
        DataBaseManager.행성대직렬정보4 = false;
        DataBaseManager.행성대직렬정보5 = false;
        DataBaseManager.행성대직렬정보6 = false;


        DataBaseManager.편집증정보1 = false;
        DataBaseManager.편집증정보2 = false;
        DataBaseManager.편집증정보3 = false;
        DataBaseManager.편집증정보4 = false;
        DataBaseManager.편집증정보5 = false;
        DataBaseManager.편집증정보6 = false;

        DataBaseManager.불면증정보1 = false;
        DataBaseManager.불면증정보2 = false;
        DataBaseManager.불면증정보3 = false;
        DataBaseManager.불면증정보4 = false;
        DataBaseManager.불면증정보5 = false;
        DataBaseManager.불면증정보6 = false;

        DataBaseManager.하수도괴담정보1 = false;
        DataBaseManager.하수도괴담정보2 = false;
        DataBaseManager.하수도괴담정보3 = false;
        DataBaseManager.하수도괴담정보4 = false;
        DataBaseManager.하수도괴담정보5 = false;
        DataBaseManager.하수도괴담정보6 = false;


        DataBaseManager.실종된사람들정보1 = false;
        DataBaseManager.실종된사람들정보2 = false;
        DataBaseManager.실종된사람들정보3 = false;
        DataBaseManager.실종된사람들정보4 = false;
        DataBaseManager.실종된사람들정보5 = false;
        DataBaseManager.실종된사람들정보6 = false;

        DataBaseManager.비릿한냄새정보1 = false;
        DataBaseManager.비릿한냄새정보2 = false;
        DataBaseManager.비릿한냄새정보3 = false;
        DataBaseManager.비릿한냄새정보4 = false;
        DataBaseManager.비릿한냄새정보5 = false;
        DataBaseManager.비릿한냄새정보6 = false;


        DataBaseManager.강의수질정보1 = false;
        DataBaseManager.강의수질정보2 = false;
        DataBaseManager.강의수질정보3 = false;
        DataBaseManager.강의수질정보4 = false;
        DataBaseManager.강의수질정보5 = false;
        DataBaseManager.강의수질정보6 = false;


        DataBaseManager.섬뜩한눈정보1 = false;
        DataBaseManager.섬뜩한눈정보2 = false;
        DataBaseManager.섬뜩한눈정보3 = false;
        DataBaseManager.섬뜩한눈정보4 = false;
        DataBaseManager.섬뜩한눈정보5 = false;
        DataBaseManager.섬뜩한눈정보6 = false;

        DataBaseManager.하수도노동자정보1 = false;
        DataBaseManager.하수도노동자정보2 = false;
        DataBaseManager.하수도노동자정보3 = false;
        DataBaseManager.하수도노동자정보4 = false;
        DataBaseManager.하수도노동자정보5 = false;
        DataBaseManager.하수도노동자정보6 = false;

        DataBaseManager.급격한교체정보1 = false;
        DataBaseManager.급격한교체정보2 = false;
        DataBaseManager.급격한교체정보3 = false;
        DataBaseManager.급격한교체정보4 = false;
        DataBaseManager.급격한교체정보5 = false;
        DataBaseManager.급격한교체정보6 = false;


        //장소정보
        DataBaseManager.탐정사무소현재페이지 = 1;
        DataBaseManager.병원현재페이지 = 1;
        DataBaseManager.신문사현재페이지 = 1;
        DataBaseManager.의뢰자의집현재페이지 = 1;
        DataBaseManager.아컴역현재페이지 = 1;
        DataBaseManager.식당현재페이지 = 1;
        DataBaseManager.대학현재페이지 = 1;
        DataBaseManager.강가현재페이지 = 1;
        DataBaseManager.술집현재페이지 = 1;
        DataBaseManager.빈민가현재페이지 = 1;
        DataBaseManager.경찰서현재페이지 = 1;
        DataBaseManager.총포상현재페이지 = 1;
        DataBaseManager.하수정비사무소현재페이지 = 1;


        DataBaseManager.현재획득한장소정보가지수 = 0;
        DataBaseManager.탐정사무소버튼순서 = -1;
        DataBaseManager.병원버튼순서 = -1;
        DataBaseManager.신문사버튼순서 = -1;
        DataBaseManager.의뢰자의집버튼순서 = -1;
        DataBaseManager.아컴역버튼순서 = -1;
        DataBaseManager.식당버튼순서 = -1;
        DataBaseManager.대학버튼순서 = -1;
        DataBaseManager.강가버튼순서 = -1;
        DataBaseManager.술집버튼순서 = -1;
        DataBaseManager.빈민가버튼순서 = -1;
        DataBaseManager.경찰서버튼순서 = -1;
        DataBaseManager.총포상버튼순서 = -1;
        DataBaseManager.하수정비사무소버튼순서 = -1;



        DataBaseManager.탐정사무소정보1 = false;
        DataBaseManager.탐정사무소정보2 = false;
        DataBaseManager.탐정사무소정보3 = false;
        DataBaseManager.탐정사무소정보4 = false;
        DataBaseManager.탐정사무소정보5 = false;
        DataBaseManager.탐정사무소정보6 = false;


        DataBaseManager.병원정보1 = false;
        DataBaseManager.병원정보2 = false;
        DataBaseManager.병원정보3 = false;
        DataBaseManager.병원정보4 = false;
        DataBaseManager.병원정보5 = false;
        DataBaseManager.병원정보6 = false;

        DataBaseManager.신문사정보1 = false;
        DataBaseManager.신문사정보2 = false;
        DataBaseManager.신문사정보3 = false;
        DataBaseManager.신문사정보4 = false;
        DataBaseManager.신문사정보5 = false;
        DataBaseManager.신문사정보6 = false;

        DataBaseManager.의뢰자의집정보1 = false;
        DataBaseManager.의뢰자의집정보2 = false;
        DataBaseManager.의뢰자의집정보3 = false;
        DataBaseManager.의뢰자의집정보4 = false;
        DataBaseManager.의뢰자의집정보5 = false;
        DataBaseManager.의뢰자의집정보6 = false;

        DataBaseManager.아컴역정보1 = false;
        DataBaseManager.아컴역정보2 = false;
        DataBaseManager.아컴역정보3 = false;
        DataBaseManager.아컴역정보4 = false;
        DataBaseManager.아컴역정보5 = false;
        DataBaseManager.아컴역정보6 = false;


        DataBaseManager.식당정보1 = false;
        DataBaseManager.식당정보2 = false;
        DataBaseManager.식당정보3 = false;
        DataBaseManager.식당정보4 = false;
        DataBaseManager.식당정보5 = false;
        DataBaseManager.식당정보6 = false;


        DataBaseManager.대학정보1 = false;
        DataBaseManager.대학정보2 = false;
        DataBaseManager.대학정보3 = false;
        DataBaseManager.대학정보4 = false;
        DataBaseManager.대학정보5 = false;
        DataBaseManager.대학정보6 = false;

        DataBaseManager.강가정보1 = false;
        DataBaseManager.강가정보2 = false;
        DataBaseManager.강가정보3 = false;
        DataBaseManager.강가정보4 = false;
        DataBaseManager.강가정보5 = false;
        DataBaseManager.강가정보6 = false;

        DataBaseManager.술집정보1 = false;
        DataBaseManager.술집정보2 = false;
        DataBaseManager.술집정보3 = false;
        DataBaseManager.술집정보4 = false;
        DataBaseManager.술집정보5 = false;
        DataBaseManager.술집정보6 = false;


        DataBaseManager.빈민가정보1 = false;
        DataBaseManager.빈민가정보2 = false;
        DataBaseManager.빈민가정보3 = false;
        DataBaseManager.빈민가정보4 = false;
        DataBaseManager.빈민가정보5 = false;
        DataBaseManager.빈민가정보6 = false;


        DataBaseManager.경찰서정보1 = false;
        DataBaseManager.경찰서정보2 = false;
        DataBaseManager.경찰서정보3 = false;
        DataBaseManager.경찰서정보4 = false;
        DataBaseManager.경찰서정보5 = false;
        DataBaseManager.경찰서정보6 = false;

        DataBaseManager.총포상정보1 = false;
        DataBaseManager.총포상정보2 = false;
        DataBaseManager.총포상정보3 = false;
        DataBaseManager.총포상정보4 = false;
        DataBaseManager.총포상정보5 = false;
        DataBaseManager.총포상정보6 = false;

        DataBaseManager.하수정비사무소정보1 = false;
        DataBaseManager.하수정비사무소정보2 = false;
        DataBaseManager.하수정비사무소정보3 = false;
        DataBaseManager.하수정비사무소정보4 = false;
        DataBaseManager.하수정비사무소정보5 = false;
        DataBaseManager.하수정비사무소정보6 = false;


        SceneManager.LoadScene("SetCharacter");
    }
    public void 게임종료버튼()
    {
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
        if(대화창켜야하나 == true)
        {
            대화창1.SetActive(true);
            대화창2.SetActive(true);

        }

        대화창켜야하나 = false;
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
