using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UpperUIManager : MonoBehaviour
{

    public GameObject 이동확인알람;
    public GameObject 페이드이미지오브젝트;
    public Image 페이드이미지;
    public void 일과종료버튼클릭()
    {
        데모종료안내.SetActive(true);
        //이동확인알람.SetActive(true);
        // DataBaseManager.이동지 = "";
    }
    public void 일과종료버튼아니오()
    {

        이동확인알람.SetActive(false);

    }
    public void 일과종료버튼예()
    {
        //페이드아웃();
  

    }

    public void 시간이동으로씬전환()
    {



        SceneManager.LoadScene("1st_Mor_MyROOM_1일차종료");

    }

    public void 페이드아웃()
    {
        StartCoroutine(페이드아웃코루틴());
    }

    IEnumerator 페이드아웃코루틴()
    {
        페이드이미지오브젝트.SetActive(true);
        float 페이드카운트 = 0;
        while (페이드카운트 < 1.0f)
        {
            페이드카운트 += 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);


        }


        //시간이동으로씬전환();
    }
    public GameObject 데모종료안내;
    public GameObject 종료;
    public GameObject 다시하기;

    public void 종료버튼클릭()
    {
        Application.Quit();
    }

    public void 다시하기클릭()
    {
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
        DataBaseManager.카메라워킹온오프= false;
        DataBaseManager.카메라왼쪽워킹온오프= false;

        DataBaseManager.스킵활성화 = false;
        DataBaseManager.시간대 = 1;
        DataBaseManager.이동지="";

        DataBaseManager.음악소리크기 = 0.5f;
        DataBaseManager.이펙트소리크기 = 0.5f;


        // Start is called before the first frame update
        DataBaseManager.힘=0;
        DataBaseManager.지능=0;
        DataBaseManager.민첩=0;
        DataBaseManager.행운=0;

        DataBaseManager.활력=0;
        DataBaseManager.마력=0;
        DataBaseManager.의지력=0;

        DataBaseManager.체력=0;
        DataBaseManager.정신력=0;
        DataBaseManager.현재체력=0;
        DataBaseManager.현재정신력=0;
        DataBaseManager.스트레스게이지=0;



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
        DataBaseManager. 붕대감기 = 0;
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
        DataBaseManager. 강가현재페이지 = 1;
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
        DataBaseManager.아침사무소연출 = false;

        SceneManager.LoadScene("SetCharacter");
    }
IEnumerator 페이드인코루틴()
    {

        float 페이드카운트 = 1;
        while (페이드카운트 > 0.0f)
        {
            페이드카운트 -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);


        }

        페이드이미지오브젝트.SetActive(false);

    }


    public GameObject 지도켜기버튼;
    public GameObject 일과종료버튼;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(페이드인코루틴());
        if (DataBaseManager.시간대 % 4 == 0)
        {
            지도켜기버튼.SetActive(false);
            일과종료버튼.SetActive(true);
        }
        else
        {
            지도켜기버튼.SetActive(true);
            일과종료버튼.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
