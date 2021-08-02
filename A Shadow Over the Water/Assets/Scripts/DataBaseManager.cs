using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataBaseManager : MonoBehaviour
{
    public static bool 장면이동중;


    public static bool  스킵활성화 = false;
    public static int 시간대 = 2;
    public static string 이동지;
    public static float 텍스트딜레이;
    public static float 음악소리크기 = 0.5f;
    public static float 이펙트소리크기 = 0.5f;

    public static bool 노아정보1=true;
    public static bool 노아정보2=false;
    public static bool 노아정보3=false;
    public static bool 노아정보4=false;
    public static bool 노아정보5=false;
    public static bool 노아정보6=false;

    public static bool 악몽정보1 = true;
    public static bool 악몽정보2 = false;
    public static bool 악몽정보3 = false;
    public static bool 악몽정보4 = false;
    public static bool 악몽정보5 = false;
    public static bool 악몽정보6 = false;

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


    //총알
    public static int 보유리볼버탄약 = 6;
    public static int 보유소총탄약 = 6;
    public static int 보유권총탄약 = 6;
    public static int 보유샷건탄약 = 6;

    public static int 화염병보유수 = 0;
    public static int 리볼버장탄수 = 0;
    public static int 소총장탄수 = 0;
    public static int 샷건장탄수 = 0;
    public static int 소형권총장탄수 = 0;


    public static bool 메뉴창켜짐 = false;

    //1일차 오전 사무소 확인여부
    public static bool _1일차오전심리학판정성공여부 = false;
    public static bool 선택1_3가만히있기를했는가 = false;



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
}
