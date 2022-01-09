using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataBaseManager : MonoBehaviour
{
    public static string 키워드주제 = "";
    public static string 키워드상위 = "";
    public static string 키워드하위 = "";

    public static bool 하수도관찰력판정여부 = false;
    public static bool 노교수관찰력판정여부 = false;

    public static bool 대학생관찰력판정여부 = false;

    public static bool 스탠리언변술판정여부 = false;
    public static bool 스탠리심리학판정여부 = false;
    public static bool 스탠리언변술성공여부 = false;


    public static bool 에이든의학판정여부 = false;
    public static bool 에이든정신분석판정여부 = false;
    public static bool 에이든1일차최초대화완료여부 = false;

    public static bool 최초의뢰인집 = false;

    public static bool 대화중기능판정 = false;
    public static bool 연출진행중 = false;
    //정보 알리미 관련 
    public static bool 정보창알리미 = false;
    public static bool 사건창알리미 = false;
    public static bool 인물창알리미 = false;
    public static bool 장소창알리미 = false;

    public static bool 노아알리미 = false;
    public static bool 멜리사알리미 = false;
    public static bool 엘라알리미 = false;
    public static bool 에이든알리미 = false;

    public static bool 악몽알리미 = false;
    public static bool 행성대직렬알리미 = false;
    public static bool 편집증알리미 = false;
    public static bool 불면증알리미 = false;
    public static bool 실종사건알리미 = false;

    public static bool 탐정사무소알리미 = false;
    public static bool 병원알리미 = false;
    public static bool 신문사알리미 = false;
    public static bool 의뢰자의집알리미 = false;
    public static bool 아캄역알리미 = false;


    public static bool 옵션창여부 = false;
    public static bool 판정창여부 = false;
    //기능판정관련.(사물,기물,인물반응)

    //탐정사무소기능반응
    public static bool 신문기능판정여부 = false;


    //총알
    public static int 보유리볼버탄약 = 0;
    public static int 보유소총탄약 = 0;
    public static int 보유권총탄약 = 0;
    public static int 보유샷건탄약 = 0;
    public static int 화염병보유수 = 0;
    
    
    public static int 리볼버장탄수 = 0;
    public static int 소총장탄수 = 0;
    public static int 샷건장탄수 = 0;
    public static int 소형권총장탄수 = 0;

    //상점구매관련, 재력관련 파트
    public static int 재력 = 0;
    public static bool 리볼버구매여부 = false;
    public static bool 소형권총구매여부 = false;
    public static bool 샷건구매여부 = false;
    public static bool 소총구매여부 = false;

    public static bool 몽둥이구매여부 = false;
    public static bool 단검구매여부 = false;
    public static bool 도끼구매여부 = false;



    //
    public static bool 연출중움직임제한;


    public static bool 장면이동중;
    public static bool 카메라워킹온오프;
    public static bool 카메라왼쪽워킹온오프;

    public static bool  스킵활성화 = false;
    public static int 시간대 = 1;
    public static string 이동지;
    public static float 텍스트딜레이;
    public static float 음악소리크기 = 0.5f;
    public static float 이펙트소리크기 = 0.5f;


    // Start is called before the first frame update
    public static int 힘;
    public static int 지능;
    public static int 민첩;
    public static int 행운;

    public static int 활력;
    public static int 마력;
    public static int 의지력;

    public static int 체력;
    public static int 정신력;
    public static int 현재체력;
    public static int 현재정신력;
    public static int 스트레스게이지;



    //힘 기반
    public static int 맨손격투=0;
    public static int 사격술=0;
    public static int 검술 = 0;
    public static int 고문술 = 0;
    public static int 눈썰미 = 0;
    public static int 언변술_협박 = 0;
    public static int 던지기 = 0;
    public static int 잠수 = 0;
    //지능 기반
    public static int 의학지식 = 0;
    public static int 정보조사 = 0;
    public static int 심리판단 = 0;
    public static int 오컬트지식 = 0;
    public static int 정신감정 = 0;
    public static int 언변술_설득 = 0;
    public static int 붕대감기 = 0;
    public static int 법의학 = 0;
    //민첩 기반
    public static int 구르기 = 0;
    public static int 변장술 = 0;
    public static int 언변술 = 0;
    public static int 자물쇠따기 = 0;
    public static int 손재주 = 0;
    public static int 은신 = 0;
    public static int 연기술 = 0;
    public static int 운동신경 = 0;


    public static bool 대화창켜짐 = false;



    public static bool 메뉴창켜짐 = false;

    //1일차 오전 사무소 확인여부
    public static bool _1일차오전심리학판정성공여부 = false;
    public static bool 선택1_3가만히있기를했는가 = false;


    //획득정보 확인.

  

    void 매뉴창켜지면정지()
    {
        if (메뉴창켜짐 == false)
        {
            Time.timeScale = 1;
        }
        if (메뉴창켜짐 == true)
        {
            Time.timeScale = 0;
        }
    }
    


    static public DataBaseManager instance;

    [SerializeField] string csv_FileName;

    Dictionary<int, Dialog> dialogDic = new Dictionary<int, Dialog>();

    public static bool isFinish;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }

 
        힘 = 0;
        지능 = 0;
        민첩 = 0;
        행운 = 0;
        활력 = 0;
        마력 = 0;
        의지력 = 0;
        체력 = 0;

        정신력 = 0;
        스트레스게이지 = 0;
        맨손격투 = 0;
        사격술 = 0;

        검술 = 0;
        고문술 = 0;
        눈썰미 = 0;
        언변술_협박 = 0;
        던지기 = 0;
        잠수 = 0;
        의학지식 = 0;
        정보조사 = 0;
        심리판단 = 0;
        오컬트지식 = 0;
        정신감정 = 0;
        언변술_설득= 0;
        붕대감기 = 0;
        법의학 = 0;
        구르기 = 0;
        변장술 = 0;
        언변술 = 0;
        자물쇠따기 = 0;
        손재주 = 0;
        은신 = 0;
        연기술 = 0;
        운동신경 = 0;





    }

    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //인물정보

    public static int 노아현재페이지 = 1;
    public static int 멜리사현재페이지 = 1;
    public static  int 엘라현재페이지 = 1;
    public static  int 에이든현재페이지 = 1;
    public static  int 노교수현재페이지 = 1;
    public static  int 하수정비사무소장현재페이지 = 1;
    public static int 경찰친구현재페이지 = 1;
    public static int 술집친구현재페이지 = 1;
    public static int 동료기자현재페이지 = 1;

    public static int 현재획득한인물정보가지수 = 0;

    public static int 노아버튼순서 = -1;
    public static int 멜리사버튼순서 = -1;
    public static int 엘라버튼순서 = -1;
    public static int 에이든버튼순서 = -1;
    public static int 노교수버튼순서 = -1;
    public static int 경찰친구버튼순서 = -1;
    public static int 술집친구버튼순서 = -1;
    public static int 하수정비사무소소장버튼순서 = -1;
    public static int 동료기자버튼순서 = -1;


    public static bool 노아정보1 = false;
    public static bool 노아정보2 = false;
    public static bool 노아정보3 = false;
    public static bool 노아정보4 = false;
    public static bool 노아정보5 = false;
    public static bool 노아정보6 = false;

    public static bool 멜리사정보1 = false;
    public static bool 멜리사정보2 = false;
    public static bool 멜리사정보3 = false;
    public static bool 멜리사정보4 = false;
    public static bool 멜리사정보5 = false;
    public static bool 멜리사정보6 = false;

    public static bool 에이든정보1 = false;
    public static bool 에이든정보2 = false;
    public static bool 에이든정보3 = false;
    public static bool 에이든정보4 = false;
    public static bool 에이든정보5 = false;
    public static bool 에이든정보6 = false;

    public static bool 엘라정보1 = false;
    public static bool 엘라정보2 = false;
    public static bool 엘라정보3 = false;
    public static bool 엘라정보4 = false;
    public static bool 엘라정보5 = false;
    public static bool 엘라정보6 = false;

    public static bool 동료기자정보1 = false;
    public static bool 동료기자정보2 = false;
    public static bool 동료기자정보3 = false;
    public static bool 동료기자정보4 = false;
    public static bool 동료기자정보5 = false;
    public static bool 동료기자정보6 = false;

    public static bool 노교수정보1 = false;
    public static bool 노교수정보2 = false;
    public static bool 노교수정보3 = false;
    public static bool 노교수정보4 = false;
    public static bool 노교수정보5 = false;
    public static bool 노교수정보6 = false;

    public static bool 경찰친구정보1 = false;
    public static bool 경찰친구정보2 = false;
    public static bool 경찰친구정보3 = false;
    public static bool 경찰친구정보4 = false;
    public static bool 경찰친구정보5 = false;
    public static bool 경찰친구정보6 = false;

    public static bool 술집친구정보1 = false;
    public static bool 술집친구정보2 = false;
    public static bool 술집친구정보3 = false;
    public static bool 술집친구정보4 = false;
    public static bool 술집친구정보5 = false;
    public static bool 술집친구정보6 = false;

    public static bool 하수정비사무소소장정보1 = false;
    public static bool 하수정비사무소소장정보2 = false;
    public static bool 하수정비사무소소장정보3 = false;
    public static bool 하수정비사무소소장정보4 = false;
    public static bool 하수정비사무소소장정보5 = false;
    public static bool 하수정비사무소소장정보6 = false;



    //사건정보

    public static int 행성대직렬현재페이지 = 1;
    public static int 악몽현재페이지 = 1;
    public static int 편집증현재페이지 = 1;
    public static int 불면증현재페이지 = 1;
    public static int 하수도괴담현재페이지 = 1;
    public static int 실종된사람들현재페이지 = 1;
    public static int 비릿한냄새현재페이지 = 1;
    public static int 강의수질현재페이지 = 1;
    public static int 섬뜩한눈현재페이지 = 1;
    public static int 하수도노동자현재페이지 = 1;
    public static int 급격한교체현재페이지 = 1;
    

    public static int 현재획득한사건정보가지수 = 0;

    public static int 행성대직렬버튼순서 = -1;
    public static int 악몽버튼순서 = -1;
    public static int 편집증버튼순서 = -1;
    public static int 불면증버튼순서 = -1;
    public static int 하수도괴담버튼순서 = -1;
    public static int 실종된사람들버튼순서 = -1;
    public static int 비릿한냄새버튼순서 = -1;
    public static int 강의수질버튼순서 = -1;
    public static int 섬뜩한눈버튼순서 = -1;
    public static int 하수도노동자버튼순서 = -1;
    public static int 급격한교체버튼순서 = -1;







    public static bool 악몽정보1 = false;
    public static bool 악몽정보2 = false;
    public static bool 악몽정보3 = false;
    public static bool 악몽정보4 = false;
    public static bool 악몽정보5 = false;
    public static bool 악몽정보6 = false;

    public static bool 행성대직렬정보1 = false;
    public static bool 행성대직렬정보2 = false;
    public static bool 행성대직렬정보3 = false;
    public static bool 행성대직렬정보4 = false;
    public static bool 행성대직렬정보5 = false;
    public static bool 행성대직렬정보6 = false;


    public static bool 편집증정보1 = false;
    public static bool 편집증정보2 = false;
    public static bool 편집증정보3 = false;
    public static bool 편집증정보4 = false;
    public static bool 편집증정보5 = false;
    public static bool 편집증정보6 = false;

    public static bool 불면증정보1 = false;
    public static bool 불면증정보2 = false;
    public static bool 불면증정보3 = false;
    public static bool 불면증정보4 = false;
    public static bool 불면증정보5 = false;
    public static bool 불면증정보6 = false;

    public static bool 하수도괴담정보1 = false;
    public static bool 하수도괴담정보2 = false;
    public static bool 하수도괴담정보3 = false;
    public static bool 하수도괴담정보4 = false;
    public static bool 하수도괴담정보5 = false;
    public static bool 하수도괴담정보6 = false;


    public static bool 실종된사람들정보1 = false;
    public static bool 실종된사람들정보2 = false;
    public static bool 실종된사람들정보3 = false;
    public static bool 실종된사람들정보4 = false;
    public static bool 실종된사람들정보5 = false;
    public static bool 실종된사람들정보6 = false;

    public static bool 비릿한냄새정보1 = false;
    public static bool 비릿한냄새정보2 = false;
    public static bool 비릿한냄새정보3 = false;
    public static bool 비릿한냄새정보4 = false;
    public static bool 비릿한냄새정보5 = false;
    public static bool 비릿한냄새정보6 = false;


    public static bool 강의수질정보1 = false;
    public static bool 강의수질정보2 = false;
    public static bool 강의수질정보3 = false;
    public static bool 강의수질정보4 = false;
    public static bool 강의수질정보5 = false;
    public static bool 강의수질정보6 = false;


    public static bool 섬뜩한눈정보1 = false;
    public static bool 섬뜩한눈정보2 = false;
    public static bool 섬뜩한눈정보3 = false;
    public static bool 섬뜩한눈정보4 = false;
    public static bool 섬뜩한눈정보5 = false;
    public static bool 섬뜩한눈정보6 = false;

    public static bool 하수도노동자정보1 = false;
    public static bool 하수도노동자정보2 = false;
    public static bool 하수도노동자정보3 = false;
    public static bool 하수도노동자정보4 = false;
    public static bool 하수도노동자정보5 = false;
    public static bool 하수도노동자정보6 = false;

    public static bool 급격한교체정보1 = false;
    public static bool 급격한교체정보2 = false;
    public static bool 급격한교체정보3 = false;
    public static bool 급격한교체정보4 = false;
    public static bool 급격한교체정보5 = false;
    public static bool 급격한교체정보6 = false;



    //장소정보
    public static int 탐정사무소현재페이지 = 1;
    public static int 병원현재페이지 = 1;
    public static int 신문사현재페이지 = 1;
    public static int 의뢰자의집현재페이지 = 1;
    public static int 아컴역현재페이지 = 1;
    public static int 식당현재페이지 = 1;
    public static int 대학현재페이지 = 1;
    public static int 강가현재페이지 = 1;
    public static int 술집현재페이지 = 1;
    public static int 빈민가현재페이지 = 1;
    public static int 경찰서현재페이지 = 1;
    public static int 총포상현재페이지 = 1;
    public static int 하수정비사무소현재페이지 = 1;


    public static int 현재획득한장소정보가지수 = 0;

    public static int 탐정사무소버튼순서 = -1;
    public static int 병원버튼순서 = -1;
    public static int 신문사버튼순서 = -1;
    public static int 의뢰자의집버튼순서 = -1;
    public static int 아컴역버튼순서 = -1;
    public static int 식당버튼순서 = -1;
    public static int 대학버튼순서 = -1;
    public static int 강가버튼순서 = -1;
    public static int 술집버튼순서 = -1;
    public static int 빈민가버튼순서 = -1;
    public static int 경찰서버튼순서 = -1;
    public static int 총포상버튼순서 = -1;
    public static int 하수정비사무소버튼순서 = -1;



    public static bool 탐정사무소정보1 = false;
    public static bool 탐정사무소정보2 = false;
    public static bool 탐정사무소정보3 = false;
    public static bool 탐정사무소정보4 = false;
    public static bool 탐정사무소정보5 = false;
    public static bool 탐정사무소정보6 = false;

    public static bool 병원정보1 = false;
    public static bool 병원정보2 = false;
    public static bool 병원정보3 = false;
    public static bool 병원정보4 = false;
    public static bool 병원정보5 = false;
    public static bool 병원정보6 = false;

    public static bool 신문사정보1 = false;
    public static bool 신문사정보2 = false;
    public static bool 신문사정보3 = false;
    public static bool 신문사정보4 = false;
    public static bool 신문사정보5 = false;
    public static bool 신문사정보6 = false;

    public static bool 의뢰자의집정보1 = false;
    public static bool 의뢰자의집정보2 = false;
    public static bool 의뢰자의집정보3 = false;
    public static bool 의뢰자의집정보4 = false;
    public static bool 의뢰자의집정보5 = false;
    public static bool 의뢰자의집정보6 = false;


    public static bool 아컴역정보1 = false;
    public static bool 아컴역정보2 = false;
    public static bool 아컴역정보3 = false;
    public static bool 아컴역정보4 = false;
    public static bool 아컴역정보5 = false;
    public static bool 아컴역정보6 = false;


    public static bool 식당정보1 = false;
    public static bool 식당정보2 = false;
    public static bool 식당정보3 = false;
    public static bool 식당정보4 = false;
    public static bool 식당정보5 = false;
    public static bool 식당정보6 = false;
    

    public static bool 대학정보1 = false;
    public static bool 대학정보2 = false;
    public static bool 대학정보3 = false;
    public static bool 대학정보4 = false;
    public static bool 대학정보5 = false;
    public static bool 대학정보6 = false;

    public static bool 강가정보1 = false;
    public static bool 강가정보2 = false;
    public static bool 강가정보3 = false;
    public static bool 강가정보4 = false;
    public static bool 강가정보5 = false;
    public static bool 강가정보6 = false;

    public static bool 술집정보1 = false;
    public static bool 술집정보2 = false;
    public static bool 술집정보3 = false;
    public static bool 술집정보4 = false;
    public static bool 술집정보5 = false;
    public static bool 술집정보6 = false;


    public static bool 빈민가정보1 = false;
    public static bool 빈민가정보2 = false;
    public static bool 빈민가정보3 = false;
    public static bool 빈민가정보4 = false;
    public static bool 빈민가정보5 = false;
    public static bool 빈민가정보6 = false;


    public static bool 경찰서정보1 = false;
    public static bool 경찰서정보2 = false;
    public static bool 경찰서정보3 = false;
    public static bool 경찰서정보4 = false;
    public static bool 경찰서정보5 = false;
    public static bool 경찰서정보6 = false;

    public static bool 총포상정보1 = false;
    public static bool 총포상정보2 = false;
    public static bool 총포상정보3 = false;
    public static bool 총포상정보4 = false;
    public static bool 총포상정보5 = false;
    public static bool 총포상정보6 = false;

    public static bool 하수정비사무소정보1 = false;
    public static bool 하수정비사무소정보2 = false;
    public static bool 하수정비사무소정보3 = false;
    public static bool 하수정비사무소정보4 = false;
    public static bool 하수정비사무소정보5 = false;
    public static bool 하수정비사무소정보6 = false;
    

}
